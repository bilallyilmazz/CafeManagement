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
    public class CompanySettingSeed : IEntityTypeConfiguration<CompanySetting>
    {
        public void Configure(EntityTypeBuilder<CompanySetting> builder)
        {

            builder.HasData(
                new CompanySetting
                {
                    Id = 1,
                    CompanyId = 1,
                    IsUseMernis=true
                },

                new CompanySetting
                {
                    Id = 2,
                    CompanyId = 2,
                    IsUseMernis=false
                }
                );
        }
    }
}
