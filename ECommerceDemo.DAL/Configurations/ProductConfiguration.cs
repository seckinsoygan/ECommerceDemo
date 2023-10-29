using ECommerceDemo.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceDemo.DAL.Configurations
{
    public class ProductConfiguration : BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.OrderDetails).WithOne(x => x.Product).HasForeignKey(x => x.ProductId).IsRequired();
        }
    }
}
