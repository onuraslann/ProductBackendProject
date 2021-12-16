using Microsoft.EntityFrameworkCore;
using Product.Core.DataAccess.Concrete.EntityFramework;
using Product.DataAccess.Abstract;
using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Concrete.EntityFramework
{
    public class EfColorDal: EfEntityRepositoryBase<Color>,IColorDal
    {
        public EfColorDal(DbContext context) : base(context)
        {

        }
    }
}
