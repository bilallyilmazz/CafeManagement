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

    public class CompanyController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Company> _service;

        public CompanyController(IMapper mapper, IService<Company> productService)
        {

            _mapper = mapper;
            _service = productService;
        }


        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {

            var categories = await _service.GetAllAsync();

            var categoriesDto = _mapper.Map<List<CompanyDto>>(categories.ToList());

            return CreateActionResult(CustomResponseDto<List<CompanyDto>>.Success(200, categoriesDto));

        }
    }
}
