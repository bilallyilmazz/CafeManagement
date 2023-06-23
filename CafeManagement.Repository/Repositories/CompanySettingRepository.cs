using CafeManagement.Core.Entities;
using CafeManagement.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Repository.Repositories
{
    public class CompanySettingRepository : GenericRepository<CompanySetting>,ICompanySettingRepository
    {
        public CompanySettingRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<bool> SettingsUpdateMernis(int companyId, bool isMernis)
        {
            var companySetting= await _context.CompanySettings.FirstOrDefaultAsync(x=>x.CompanyId==companyId);

            companySetting.IsUseMernis = isMernis;

           var result= await _context.SaveChangesAsync();

            if (result == 0)
                return false;

            return true;
        }
    }
}
