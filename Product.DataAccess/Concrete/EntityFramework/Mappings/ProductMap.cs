using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Entities.Concrete.Productt>
    {
        public void Configure(EntityTypeBuilder<Entities.Concrete.Productt> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.ProductName).HasMaxLength(100);
            builder.Property(p => p.Stock).IsRequired();
            builder.Property(p => p.ModifiedByName).IsRequired();
            builder.Property(p => p.ModifiedByName).HasMaxLength(50);
            builder.Property(p => p.CreatedByName).HasMaxLength(50);
            builder.Property(p => p.CreatedDate).IsRequired();
            builder.Property(p => p.ModifedDate).IsRequired();
            builder.Property(p => p.IsActive).IsRequired();
            builder.Property(p => p.IsDeleted).IsRequired(); 
            builder.HasOne<Category>(p => p.Category).WithMany(c => c.Productts).HasForeignKey(p=>p.CategoryId);
            builder.HasOne<Brand>(p => p.Brand).WithMany(b => b.Productts).HasForeignKey(p => p.BrandId); 
            builder.HasOne<Color>(p => p.Color).WithMany(c => c.Productts).HasForeignKey(p => p.ColorId);
            builder.ToTable("Productts");
            builder.HasData(new Productt
            {
                Id = 1,
                BrandId = 1,
                ColorId = 1,
                CategoryId = 1,
                Price = 7500,
                Stock = 20,
                ProductName = "Bilgisayar",
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
