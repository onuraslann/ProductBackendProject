using Product.Core.DataAccess.Abstract;
using Product.Entities.Concrete;
using Product.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Abstract
{
   public  interface IProductDal: IEntityRepository<Entities.Concrete.Productt>
    {
        List<ProductDetailDto> GetByDto();
    }
}
