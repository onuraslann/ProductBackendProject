using Product.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity
    {
        Task<T> GetAsync(Expression<Func<T,bool>> expression);
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> expression = null);

        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> Any(Expression<Func<T, bool>> expression);
        T Add(T entity);
        T Update(T entity);
        List<T> GetAll(Expression<Func<T, bool>> expression = null);
    }
}
