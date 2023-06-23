using CafeManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Repository.Seeds
{
    internal class CustomerSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            builder.HasData(
                new Customer { 
                    Id=1,
                    Name="Burak",
                    Surname="Şentürk",
                    Email="burksenturk@gmaill.com",
                    Phone="5555555555",
                    IdentityNumber="55090143816",
                    CompanyId=1},

                new Customer
                {
                    Id = 2,
                    Name = "Bilal",
                    Surname = "Yılmaz",
                    Email = "bllylmz@gmaill.com",
                    Phone = "5555555555",
                    CompanyId = 2
                }
                );
        }
    }
}
