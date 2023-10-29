using ECommerceDemo.Entities.Abstract;
using ECommerceDemo.Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace ECommerceDemo.Entities.Concrete
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public AppUser()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
        public virtual AppUserProfile AppUserProfile { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
