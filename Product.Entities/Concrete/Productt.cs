using Product.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Entities.Concrete
{
    public class Productt:EntityBase,IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category  { get; set; }
        public int Stock { get; set; }
        public Nullable<double> Price { get; set; }
        public string ProductName { get; set; }

        public int ColorId { get; set; }
        public Color Color { get; set; }
        public int BrandId { get; set; }
        public Brand Brand  { get; set; }

    }
}
