using ECommerceDemo.DAL.Context;
using ECommerceDemo.DAL.Repositories.Abstract;
using ECommerceDemo.Entities.Concrete;

namespace ECommerceDemo.DAL.Repositories.Concrete
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
