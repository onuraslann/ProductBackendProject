using Product.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Entities.Concrete
{
    public class Color:EntityBase,IEntity
    {
     
        public string ColorName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
