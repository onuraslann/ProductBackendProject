using Microsoft.Extensions.DependencyInjection;
using Product.Business.Services.Abstract;
using Product.Business.Services.Concrete;
using Product.DataAccess.Abstract;
using Product.DataAccess.Concrete;
using Product.DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Business.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ProductContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork >();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IProductService, ProductManager>();
            serviceCollection.AddScoped<IColorService, ColorManager>();
            serviceCollection.AddScoped<IBrandService, BrandManager>();
            return serviceCollection;
        }
    }
}
