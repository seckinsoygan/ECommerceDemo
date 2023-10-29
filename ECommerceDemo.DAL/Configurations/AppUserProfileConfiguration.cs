using ECommerceDemo.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceDemo.DAL.Configurations
{
    public class AppUserProfileConfiguration : BaseConfiguration<AppUserProfile>
    {
        public override void Configure(EntityTypeBuilder<AppUserProfile> builder)
        {
            base.Configure(builder);
        }
    }
}
