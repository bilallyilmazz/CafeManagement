using AutoMapper;
using CafeManagement.Core.Entities;
using CafeManagement.Core.Repositories;
using CafeManagement.Core.Services;
using CafeManagement.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;

namespace CafeManagement.Service.Services
{
    public class CompanyService : Service<Company>, ICompanyService
    {

        private readonly ICompanySettingRepository _companySettingRepository;

        private readonly IMapper _mapper;

        public CompanyService(IGenericRepository<Company> repository, IUnitOfWork unitOfWork, IMapper mapper, ICompanySettingRepository companySettingRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;

            _companySettingRepository = companySettingRepository;
        }

        public Task<bool> SettingsUpdateMernis(int companyId, bool isMernis)
        {
            return _companySettingRepository.SettingsUpdateMernis(companyId,isMernis);
        }

        public async Task<bool> MernisControl(int companyId)
        {
            return _companySettingRepository.Where(x => x.CompanyId == companyId).FirstOrDefaultAsync().Result.IsUseMernis;
        }
    }
}
