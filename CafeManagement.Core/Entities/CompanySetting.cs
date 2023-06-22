using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Core.Entities
{
    public class CompanySetting:BaseEntity
    {
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public bool IsUseMernis { get; set; } = false;

    }
}
