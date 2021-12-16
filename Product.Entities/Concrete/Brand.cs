using Product.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Entities.Concrete
{
   public  class Brand: EntityBase, IEntity
    {
      
        public string BrandName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
