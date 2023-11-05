using ECommerceDemo.Entities.Abstract;
using System.Linq.Expressions;

namespace ECommerceDemo.BLL.Abstract
{
    public interface IService<T> where T : class, IEntity
    {
        IQueryable<T> GetAllAsync(Expression<Func<T, bool>> filter = null);
        T Get(int id);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
