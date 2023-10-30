using ECommerceDemo.DAL.Context;
using ECommerceDemo.DAL.Repositories.Abstract;
using ECommerceDemo.Entities.Concrete;

namespace ECommerceDemo.DAL.Repositories.Concrete
{
    public class AppUserProfileRepository : Repository<AppUserProfile>, IAppUserProfileRepository
    {
        public AppUserProfileRepository(AppDbContext context) : base(context)
        {
        }
    }
}
