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
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

        //Relational Properties
        public virtual AppUserProfile Profile { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
