using Product.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Entities.Concrete
{
    public class OperaitonClaim:EntityBase,IEntity
    {
        public string Name { get; set; }
        public string Decription { get; set; }
        public ICollection<User> User { get; set; }
    }
}
