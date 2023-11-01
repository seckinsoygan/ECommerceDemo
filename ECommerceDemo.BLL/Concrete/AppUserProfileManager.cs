using ECommerceDemo.BLL.Abstract;
using ECommerceDemo.DAL.Repositories.Abstract;
using ECommerceDemo.Entities.Concrete;

namespace ECommerceDemo.BLL.Concrete
{
    public class AppUserProfileManager : Manager<AppUserProfile>, IAppUserProfileService
    {
        public AppUserProfileManager(IRepository<AppUserProfile> repository) : base(repository)
        {
        }
    }
}
