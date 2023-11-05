using ECommerceDemo.BLL.Abstract;
using ECommerceDemo.DAL.Repositories.Abstract;
using ECommerceDemo.Entities.Abstract;
using System.Linq.Expressions;

namespace ECommerceDemo.BLL.Concrete
{
    public class Manager<T> : IService<T> where T : class, IEntity
    {

        private readonly IRepository<T> _repository;

        public Manager(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public IQueryable<T> GetAllAsync(Expression<Func<T, bool>> filter = null)
        {
            return _repository.GetAllAsync(filter);
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            return _repository.GetAsync(filter);
        }

        public T Get(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }
    }
}
