using CafeManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Repository.Repositories
{
    public class CustomerRepository:GenericRepository<Customer>
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }
    }
}
