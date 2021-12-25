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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.CategoryName).IsRequired(true);
            builder.Property(c => c.CategoryName).HasColumnType("NVARCHAR(MAX)");
            builder.Property(c => c.Description).HasMaxLength(500);
            builder.Property(c => c.Description).IsRequired();
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c=> c.ModifedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.ToTable("Categories");
            builder.HasData(new Category
            {
                Id = 1,
                CategoryName = "Teknolojik Aletler",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                 Description= "Teknolojik Ürünler; teknoloji kullanılarak üretilen aletler, araç-gereçlerdir " 

            });
        }
    }
}
