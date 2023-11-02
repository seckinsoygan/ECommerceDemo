using ECommerceDemo.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceDemo.DAL.Configurations
{
    public class OrderDetailConfiguration : BaseConfiguration<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new
            {
                x.ProductId,
                x.OrderId
            });
        }
    }
}
