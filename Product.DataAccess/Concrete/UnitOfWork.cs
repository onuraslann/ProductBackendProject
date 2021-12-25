using Product.DataAccess.Abstract;
using Product.DataAccess.Concrete.EntityFramework.Contexts;
using Product.DataAccess.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductContext _context;
        private EfBrandDal _brandDal;
        private EfCategoryDal _categoryDal;
        private EfColorDal _colorDal;
        private EfProductDal _productDal;
        private EfUserDal _userDal;
        public UnitOfWork(ProductContext context)
        {
            _context = context;
           
       
    }
        public void Dispose()
        {
            _context.Dispose();
        }

        public IBrandDal Brand => _brandDal ?? new EfBrandDal(_context);

        public ICategoryDal Categories => _categoryDal ?? new EfCategoryDal(_context);

        public IColorDal Color => _colorDal ?? new EfColorDal(_context);

        public IProductDal Product => _productDal ?? new EfProductDal(_context);

        public IUserDal User => _userDal ?? new EfUserDal(_context);

      

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public int saveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
