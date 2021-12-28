using Autofac;
using AutoMapper;
using Product.Business.Services.Abstract;
using Product.Business.Services.Concrete;
using Product.DataAccess.Abstract;
using Product.DataAccess.Concrete;
using Product.DataAccess.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Business.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CatManager>().As<ICatservice>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();
           

        }
    }
}
