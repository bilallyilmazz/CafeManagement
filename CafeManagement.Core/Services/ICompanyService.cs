using CafeManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Core.Services
{
    public interface ICompanyService : IService<Company>
    {
        Task<bool> SettingsUpdateMernis(int companyId, bool isMernis);
        Task<bool> MernisControl(int companyId);

    }
}
