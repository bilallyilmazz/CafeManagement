using CafeManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Core.Repositories
{
    public interface ICompanySettingRepository : IGenericRepository<CompanySetting>
    {
        Task<bool> SettingsUpdateMernis(int companyId,bool isMernis);

    }
}
