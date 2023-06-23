using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Core.Entities
{
    public class Customer:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string? IdentityNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public static Customer Create(
            string name,
            string surname,
            string phone,
            string email,
            string identityNumber,
            DateTime birthDate,
            int companyId
            )
        {
            var customer = new Customer()
            {
                Name = name,
                Surname = surname,
                Phone = phone,
                Email = email,
                IdentityNumber = identityNumber,
                BirthDate = birthDate,
                CompanyId = companyId
               
            };

            return customer;
        }
    }
}
