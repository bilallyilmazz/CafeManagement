using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Core.Entities
{
    public class Company:BaseEntity
    {
        public string Name { get; set; }
        public List<Customer> Customers { get; set; } = new();
    }
}
