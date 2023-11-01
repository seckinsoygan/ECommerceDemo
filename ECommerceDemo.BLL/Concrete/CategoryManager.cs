using ECommerceDemo.BLL.Abstract;
using ECommerceDemo.DAL.Repositories.Abstract;
using ECommerceDemo.Entities.Concrete;

namespace ECommerceDemo.BLL.Concrete
{
    public class CategoryManager : Manager<Category>, ICategoryService
    {
        public CategoryManager(IRepository<Category> repository) : base(repository)
        {
        }
    }
}
