using ECommerceDemo.Entities.Concrete;

namespace ECommerceDemo.BLL.Abstract
{
    public interface IAppUserService : IService<AppUser>
    {
        Task<bool> CreateUser(AppUser user);
    }
}
