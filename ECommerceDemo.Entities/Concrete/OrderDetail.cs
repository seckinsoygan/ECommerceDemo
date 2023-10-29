using ECommerceDemo.Entities.Abstract;

namespace ECommerceDemo.Entities.Concrete
{
    public class OrderDetail : BaseEntity
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
