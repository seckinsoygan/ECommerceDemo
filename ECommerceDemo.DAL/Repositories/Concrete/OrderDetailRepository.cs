using ECommerceDemo.DAL.Context;
using ECommerceDemo.DAL.Repositories.Abstract;
using ECommerceDemo.Entities.Concrete;

namespace ECommerceDemo.DAL.Repositories.Concrete
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(AppDbContext context) : base(context)
        {
        }
    }
}
