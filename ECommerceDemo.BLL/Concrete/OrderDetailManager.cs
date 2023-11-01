using ECommerceDemo.BLL.Abstract;
using ECommerceDemo.DAL.Repositories.Abstract;
using ECommerceDemo.Entities.Concrete;

namespace ECommerceDemo.BLL.Concrete
{
    public class OrderDetailManager : Manager<OrderDetail>, IOrderDetailService
    {
        public OrderDetailManager(IRepository<OrderDetail> repository) : base(repository)
        {
        }
    }
}
