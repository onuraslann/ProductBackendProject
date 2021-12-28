using Product.Core.Utilities.Result;
using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Business.Services.Abstract
{
   public interface ICatservice
    {
        IDataResult<List<Category>> GetAll();
    }
}
