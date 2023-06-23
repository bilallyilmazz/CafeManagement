using AutoMapper;
using CafeManagement.Api.Model;
using CafeManagement.API.Controllers;
using CafeManagement.Core.Dtos;
using CafeManagement.Core.DTOs;
using CafeManagement.Core.Entities;
using CafeManagement.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CafeManagement.Api.Controllers
{

    public class CompanyController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICompanyService _companyService;
        private readonly IService<Company> _service;


        public CompanyController(IMapper mapper, IService<Company> productService, ICompanyService companyService)
        {

            _mapper = mapper;
            _service = productService;
            _companyService = companyService;
        }


        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {

            var companies = await _service.GetAllAsync();

            var companiesDto = _mapper.Map<List<CompanyDto>>(companies.ToList());

            return CreateActionResult(CustomResponseDto<List<CompanyDto>>.Success(200, companiesDto));

        }

        [HttpGet("get")]
        public async Task<IActionResult> Get(int Id)
        {

            var company = await _service.GetByIdAsync(Id);

            var companyDto = _mapper.Map<List<CompanyDto>>(company);

            return CreateActionResult(CustomResponseDto<List<CompanyDto>>.Success(200, companyDto));

        }


        [HttpPost("companysettingupdate")]
        public async Task<IActionResult> CompanySettingUpdate(SettingUpdateRequest setting)
        {
            if (!await _companyService.SettingsUpdateMernis(setting.CompanyId, setting.IsMernis))
                return CreateActionResult(CustomResponseDto<CompanySetting>.Fail(404,"güncelleme başarısız"));
            
                return CreateActionResult(CustomResponseDto<CompanySetting>.Success(200));

        }

        [HttpGet("getusecompany")]
        public async Task<IActionResult> GetUseCompany(int companyId)
        {

            var company = await _companyService.MernisControl(companyId);



            return CreateActionResult(CustomResponseDto<bool>.Success(200, company));

        }

    }
}

