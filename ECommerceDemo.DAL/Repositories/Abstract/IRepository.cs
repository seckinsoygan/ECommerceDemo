using ECommerceDemo.Entities.Abstract;
using System.Linq.Expressions;

namespace ECommerceDemo.DAL.Repositories.Abstract
{
    public interface IRepository<T> where T : class, IEntity
    {
        IQueryable<T> GetAllAsync(Expression<Func<T, bool>> filter = null);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
