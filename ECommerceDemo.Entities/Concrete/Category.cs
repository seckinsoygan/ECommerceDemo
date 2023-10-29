using ECommerceDemo.Entities.Abstract;

namespace ECommerceDemo.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
