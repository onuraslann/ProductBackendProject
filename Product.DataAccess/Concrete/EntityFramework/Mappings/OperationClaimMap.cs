using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Product.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Concrete.EntityFramework.Mappings
{
    public class OperationClaimMap : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).ValueGeneratedOnAdd();
            builder.Property(o => o.Name).IsRequired(true);
            builder.Property(o => o.Name).HasMaxLength(50);
            builder.Property(o => o.Decription).IsRequired(true);
            builder.Property(o => o.Decription).HasMaxLength(250);
            builder.Property(o => o.CreatedByName).IsRequired();
            builder.Property(o => o.CreatedByName).HasMaxLength(50);
            builder.Property(o => o.ModifiedByName).IsRequired();
            builder.Property(o => o.ModifiedByName).HasMaxLength(50);
            builder.Property(o => o.CreatedDate).IsRequired();
            builder.Property(o => o.ModifedDate).IsRequired();
            builder.Property(o => o.IsActive).IsRequired();
            builder.Property(o => o.IsDeleted).IsRequired();         
            builder.ToTable("OperationClaim");
            builder.HasData(new OperationClaim
            {
                Id = 1,
                Name = "Admin",
                Decription = "Admin tüm yetkilere sahiptir",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifedDate = DateTime.Now,
                ModifiedByName = "InitialCreate"
            });
        }
    }
}
