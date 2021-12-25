using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Abstract
{
    public interface IUnitOfWork:IAsyncDisposable,IDisposable
    {
        IBrandDal Brand { get; }
        ICategoryDal Categories { get; }
        IColorDal Color { get; }
        IProductDal Product { get; }

        IUserDal User { get; }
        Task<int> SaveAsync();
        int saveChanges();

    }
}
