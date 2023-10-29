using ECommerceDemo.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceDemo.DAL.Configurations
{
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Products).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);
        }
    }
}
