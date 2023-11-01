using ECommerceDemo.BLL.Abstract;
using ECommerceDemo.DAL.Repositories.Abstract;
using ECommerceDemo.Entities.Concrete;

namespace ECommerceDemo.BLL.Concrete
{
    public class ProductManager : Manager<Product>, IProductService
    {
        public ProductManager(IRepository<Product> repository) : base(repository)
        {
        }
    }
}
