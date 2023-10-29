using ECommerceDemo.Entities.Abstract;

namespace ECommerceDemo.Entities.Concrete
{
    public class AppUserProfile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
