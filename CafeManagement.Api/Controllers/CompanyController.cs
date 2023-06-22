using AutoMapper;
using CafeManagement.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CafeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICompanyService _service;

        public CompanyController(IMapper mapper, ICompanyService productService)
        {

            _mapper = mapper;
            _service = productService;
        }
    }
}
