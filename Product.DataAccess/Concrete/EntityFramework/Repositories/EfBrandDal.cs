using Microsoft.EntityFrameworkCore;
using Product.Core.DataAccess.Concrete.EntityFramework;
using Product.DataAccess.Abstract;
using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfBrandDal: EfEntityRepositoryBase<Brand>,IBrandDal
    {
        public EfBrandDal(DbContext context):base(context)
        {

        }
    }
}
