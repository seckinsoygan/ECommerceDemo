using ECommerceDemo.DAL.Context;
using ECommerceDemo.DAL.Repositories.Abstract;
using ECommerceDemo.Entities.Abstract;
using System.Linq.Expressions;

namespace ECommerceDemo.DAL.Repositories.Concrete
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            entity.Status = Entities.Enums.DataStatus.Deleted;
            entity.DeletedDate = DateTime.Now;
            _context.SaveChanges();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            return await _context.Set<T>().FindAsync(filter);
        }

        public IQueryable<T> GetAllAsync(Expression<Func<T, bool>> filter = null)
        {
            return _context.Set<T>().AsQueryable();
        }

        public void Update(T entity)
        {
            entity.Status = Entities.Enums.DataStatus.Updated;
            _context.Update(entity);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
