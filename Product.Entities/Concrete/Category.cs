using Product.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Entities.Concrete
{
    public class Category:EntityBase,IEntity
    {
       
        public string CategoryName { get; set; }
        public string  Description { get; set; }
        public ICollection<Productt> Products { get; set; }
    }
}
