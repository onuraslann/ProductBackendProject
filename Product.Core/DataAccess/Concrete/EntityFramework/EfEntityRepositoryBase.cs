using Microsoft.EntityFrameworkCore;
using Product.Core.DataAccess.Abstract;
using Product.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly DbContext _context;

        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public TEntity Add(TEntity entity)
        {
            _context.Add(entity);
            return entity;
        }

        public async Task AddAsync(TEntity entity)
        {
           await _context.Set<TEntity>().AddAsync(entity);
        }

        public async Task<bool> Any(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().AnyAsync(expression);
        }

        public async  Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Remove(entity); });
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> expression = null)
        {
            return expression == null ?
                  _context.Set<TEntity>().ToList() :
                  _context.Set<TEntity>().Where(expression).ToList();
        }

        public async  Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            return  expression == null ?
                await _context.Set<TEntity>().ToListAsync() :
                await _context.Set<TEntity>().Where(expression).ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            return  await _context.Set<TEntity>().FirstOrDefaultAsync(expression);
        }

        public TEntity Update(TEntity entity)
        {
            _context.Update(entity);
            return entity;
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Update(entity); });
        }
    }
}
