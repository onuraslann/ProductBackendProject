using Microsoft.EntityFrameworkCore;
using Product.Core.DataAccess.Concrete.EntityFramework;
using Product.DataAccess.Abstract;
using Product.DataAccess.Concrete.EntityFramework.Contexts;
using Product.Entities.Concrete;
using Product.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfProductDal: EfEntityRepositoryBase<Entities.Concrete.Productt>,IProductDal
    {
        public EfProductDal(DbContext context) : base(context)
        {

        }

        public   List<ProductDetailDto> GetByDto()
        {
            using (var context = new ProductContext())
            {
                var result = from color in context.Colors
                             join product in context.Productts
                             on color.Id equals product.ColorId
                             join brand in context.Brands on
                             product.BrandId equals brand.Id
                             join categories in context.Categories
                             on product.CategoryId equals categories.Id
                             select new ProductDetailDto
                             {
                                 BrandName = brand.BrandName,
                                 CategoryName = categories.CategoryName,
                                 ColorName = color.ColorName,
                                 ProductName = product.ProductName,
                                 Stock = product.Stock,
                                  Id=product.Id
                             };
                return  result.ToList();
            }
        }
    }
}
