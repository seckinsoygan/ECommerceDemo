using ECommerceDemo.Entities.Abstract;

namespace ECommerceDemo.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public string ShippingAddress { get; set; }
        public int? AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
