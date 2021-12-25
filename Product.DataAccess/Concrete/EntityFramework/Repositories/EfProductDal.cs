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
    public class EfProductDal: EfEntityRepositoryBase<Entities.Concrete.Productt>,IProductDal
    {
        public EfProductDal(DbContext context) : base(context)
        {

        }
    }
}
