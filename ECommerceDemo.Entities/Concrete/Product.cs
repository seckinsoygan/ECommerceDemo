using ECommerceDemo.Entities.Abstract;

namespace ECommerceDemo.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
