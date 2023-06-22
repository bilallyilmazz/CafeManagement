using AutoMapper;
using CafeManagement.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CafeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICustomerService _service;

        public CustomerController(IMapper mapper, ICustomerService productService)
        {

            _mapper = mapper;
            _service = productService;
        }
    }
}
