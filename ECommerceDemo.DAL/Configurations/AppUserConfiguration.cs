using ECommerceDemo.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceDemo.DAL.Configurations
{
    public class AppUserConfiguration : BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.Id);
            builder.HasOne(x => x.Profile).WithOne(x => x.AppUser).HasForeignKey<AppUserProfile>(x => x.Id);
            builder.HasMany(x => x.Orders).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
        }
    }
}
