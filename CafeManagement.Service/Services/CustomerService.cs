using AutoMapper;
using CafeManagement.Core.Dtos;
using CafeManagement.Core.Entities;
using CafeManagement.Core.Repositories;
using CafeManagement.Core.Services;
using CafeManagement.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Service.Services
{
    public class CustomerService : Service<Customer>, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IGenericRepository<CompanySetting> _companySettingRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        IGenericRepository<Customer> _repository;
        public CustomerService(IGenericRepository<Customer> repository, IUnitOfWork unitOfWork, IMapper mapper, ICustomerRepository customerRepository, IGenericRepository<CompanySetting> companySettingRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
            _companySettingRepository = companySettingRepository;
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<bool> CustomerCreate(CustomerCreateDto customerCreateDto)
        {
            var companySetting = _companySettingRepository.Where(x => x.Id == customerCreateDto.CompanyId).FirstOrDefault();

               return  await AddCustomer(customerCreateDto);

        }

        private async Task<bool> AddCustomer(CustomerCreateDto customerCreateDto)
        {
          
                var newCustomer = Customer.Create(
                                     customerCreateDto.Name,
                                     customerCreateDto.Surname,
                                     customerCreateDto.Phone,
                                     customerCreateDto.Email,
                                     customerCreateDto.IdentityNumber,
                                     customerCreateDto.BirthDate,
                                     customerCreateDto.CompanyId
                                      );


                await _repository.AddAsync(newCustomer);

                var result=await _unitOfWork.CommitAsync();
            if (result > 0)
                return true;

            return false;
        }




    }
}
