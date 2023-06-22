using CafeManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Core.Dtos
{
    public class CompanySettingCreateDto
    {
        public int CompanyId { get; set; }

        public bool IsUseMernis { get; set; }
    }
}
