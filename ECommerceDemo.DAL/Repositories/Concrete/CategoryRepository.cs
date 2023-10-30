using ECommerceDemo.DAL.Context;
using ECommerceDemo.DAL.Repositories.Abstract;
using ECommerceDemo.Entities.Concrete;

namespace ECommerceDemo.DAL.Repositories.Concrete
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
