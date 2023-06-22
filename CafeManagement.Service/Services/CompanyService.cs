using AutoMapper;
using CafeManagement.Core.Entities;
using CafeManagement.Core.Repositories;
using CafeManagement.Core.Services;
using CafeManagement.Core.UnitOfWorks;
using CafeManagement.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Service.Services
{
    public class CompanyService : Service<Company>, ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CompanyService(IGenericRepository<Company> repository, IUnitOfWork unitOfWork, IMapper mapper, ICompanyRepository companyRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _companyRepository = companyRepository;
        }

    }
}
