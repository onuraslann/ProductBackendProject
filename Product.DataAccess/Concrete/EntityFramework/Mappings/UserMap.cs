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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.FirstName).HasMaxLength(50);
            builder.Property(u => u.FirstName).IsRequired(true);
            builder.Property(u => u.LastName).HasMaxLength(50);
            builder.Property(u => u.LastName).IsRequired(true);
            builder.Property(u => u.Email).HasMaxLength(100);
            builder.Property(u => u.Email).IsRequired(true);
            builder.HasIndex(u => u.Email).IsUnique();  
            builder.Property(u => u.PasswordHash).HasColumnType("VARBINARY(500)");
            builder.Property(u => u.PasswordHash).IsRequired(true);
            builder.Property(u => u.CreatedByName).IsRequired();
            builder.Property(u => u.CreatedByName).HasMaxLength(50);
            builder.Property(u => u.ModifiedByName).IsRequired();
            builder.Property(u => u.ModifiedByName).HasMaxLength(50);
            builder.Property(u => u.CreatedDate).IsRequired();
            builder.Property(u => u.ModifedDate).IsRequired();
            builder.Property(u => u.IsActive).IsRequired();
            builder.Property(u => u.IsDeleted).IsRequired();
            builder.HasOne<OperationClaim>(u => u.OperationClaim).WithMany(o => o.User).HasForeignKey(u => u.OperationClaimId);
            builder.ToTable("Users");
            builder.HasData(new User
            {
                Id = 1,
                FirstName = "Onur",
                LastName = "Aslan",
                Email = "theeaslann1@gmail.com",
                 OperationClaimId=1,
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                PasswordHash = Encoding.ASCII.GetBytes("d3245b00daa3e6ef4afad47b69212cf2")
            }) ;
        }
    }
}
