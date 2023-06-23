using AutoMapper;
using CafeManagement.API.Controllers;
using CafeManagement.Core.Dtos;
using CafeManagement.Core.DTOs;
using CafeManagement.Core.Entities;
using CafeManagement.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;

namespace CafeManagement.Api.Controllers
{

    public class CustomerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Customer> _service;
        private readonly ICustomerService _customerService;
        private readonly ICompanyService _companyService;

        public CustomerController(IMapper mapper, IService<Customer> productService, ICustomerService customerService, ICompanyService companyService)
        {

            _mapper = mapper;
            _service = productService;
            _customerService = customerService;
            _companyService = companyService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {

            var categories = await _service.GetAllAsync();

            var categoriesDto = _mapper.Map<List<CustomerDto>>(categories.ToList());

            return CreateActionResult(CustomResponseDto<List<CustomerDto>>.Success(200, categoriesDto));

        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCustomer([FromBody]CustomerCreateDto customerCreateDto)
        {

            //dto ya göre şirketi al ismernis kullanıtyor mu kontrol et
            //true ise bilgileri servise yolla
            // müşteriyi ekle
            // değilse müşteriyi ekle

            var controlMernis = await _companyService.MernisControl(customerCreateDto.CompanyId);
            bool customerControl = false;
            if (controlMernis)
            {

                KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
                TCKimlikNoDogrulaResponse response = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customerCreateDto.IdentityNumber), customerCreateDto.Name, customerCreateDto.Surname, customerCreateDto.BirthDate.Year);

                if (response.Body.TCKimlikNoDogrulaResult)
                {
                    customerControl = true;

                }
                else
                {
                    customerControl = false;

                }

            }
            else
            {
                customerControl = true;
            }

            if (customerControl)
            {
                var result = await _customerService.CustomerCreate(customerCreateDto);
                if (!result)
                    return CreateActionResult(CustomResponseDto<List<CustomerDto>>.Fail(404, "Müşteri eklenemedi"));

                return CreateActionResult(CustomResponseDto<List<CustomerDto>>.Success(200));
            }

            return CreateActionResult(CustomResponseDto<List<CustomerDto>>.Fail(404, "Mernis Doğrulaması Başarısız"));


        }


    }
}
