using CafeManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Repository.Repositories
{
    public class CompanyRepository:GenericRepository<Company>
    {
        public CompanyRepository(AppDbContext context) : base(context)
        {
        }
    }
}
