using AutoMapper;
using CafeManagement.API.Controllers;
using CafeManagement.Core.Dtos;
using CafeManagement.Core.DTOs;
using CafeManagement.Core.Entities;
using CafeManagement.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CafeManagement.Api.Controllers
{

    public class CustomerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Customer> _service;
        private readonly ICustomerService _customerService;

        public CustomerController(IMapper mapper, IService<Customer> productService, ICustomerService customerService)
        {

            _mapper = mapper;
            _service = productService;
            _customerService = customerService;
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
            var result= await _customerService.CustomerCreate(customerCreateDto);
            if(!result)
                return CreateActionResult(CustomResponseDto<List<CustomerDto>>.Fail(404,"Müşteri eklenemedi"));

            return CreateActionResult(CustomResponseDto<List<CustomerDto>>.Success(200));

        }
    }
}
