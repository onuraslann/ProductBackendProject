using Product.Core.Entities.Abstract;
using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Entities.Dtos
{
   public  class BrandListDto:IDto
    {
        public IList<Brand> Brands { get; set; }
    }
}
