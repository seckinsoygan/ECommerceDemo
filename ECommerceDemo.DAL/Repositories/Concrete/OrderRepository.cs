using ECommerceDemo.DAL.Context;
using ECommerceDemo.DAL.Repositories.Abstract;
using ECommerceDemo.Entities.Concrete;

namespace ECommerceDemo.DAL.Repositories.Concrete
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }
    }
}
