using Microsoft.EntityFrameworkCore;
using Product.Core.DataAccess.Concrete.EntityFramework;
using Product.Core.Entities.Concrete;
using Product.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Concrete.EntityFramework.Repositories
{
  public   class EfUserDal: EfEntityRepositoryBase<User>,IUserDal
    {
        public EfUserDal(DbContext context) : base(context)
        {

        }
    }
}
