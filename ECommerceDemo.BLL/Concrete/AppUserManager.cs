using ECommerceDemo.BLL.Abstract;
using ECommerceDemo.DAL.Repositories.Abstract;
using ECommerceDemo.Entities.Concrete;

namespace ECommerceDemo.BLL.Concrete
{
    public class AppUserManager : Manager<AppUser>, IAppUserService
    {
        IAppUserRepository _repository;
        public AppUserManager(IAppUserRepository appUserRepository) : base(appUserRepository)
        {
            _repository = appUserRepository;
        }

        public async Task<bool> CreateUser(AppUser user)
        {
            return await _repository.AddUser(user);
        }
    }
}
