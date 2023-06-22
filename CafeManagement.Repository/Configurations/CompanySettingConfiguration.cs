using CafeManagement.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Repository.Configurations
{
 
    internal class CompanySettingConfiguration : IEntityTypeConfiguration<CompanySetting>
    {
        public void Configure(EntityTypeBuilder<CompanySetting> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CompanyId).IsRequired();
            builder.Property(x => x.IsUseMernis).IsRequired();


            builder.ToTable("CompanySettings");

        }
    }
}
