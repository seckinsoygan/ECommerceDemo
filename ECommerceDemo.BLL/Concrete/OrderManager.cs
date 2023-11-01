using ECommerceDemo.BLL.Abstract;
using ECommerceDemo.DAL.Repositories.Abstract;
using ECommerceDemo.Entities.Concrete;

namespace ECommerceDemo.BLL.Concrete
{
    public class OrderManager : Manager<Order>, IOrderService
    {
        public OrderManager(IRepository<Order> repository) : base(repository)
        {
        }
    }
}
