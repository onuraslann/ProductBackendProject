using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Entities.Abstract
{
    public abstract  class EntityBase
    {
  
        public virtual bool IsDeleted { get; set; } = false;
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifedDate { get; set; }
        public virtual bool IsActive { get; set; } 
        public virtual string CreatedByName  { get; set; }
        public virtual string ModifiedByName { get; set; }
    }
}
