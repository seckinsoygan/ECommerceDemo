using ECommerceDemo.DAL.Context;
using ECommerceDemo.DAL.Repositories.Abstract;
using ECommerceDemo.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace ECommerceDemo.DAL.Repositories.Concrete
{
    public class AppUserRepository : Repository<AppUser>, IAppUserRepository
    {
        UserManager<AppUser> _manager;
        public AppUserRepository(AppDbContext context, UserManager<AppUser> manager) : base(context)
        {
            _manager = manager;
        }
        public async Task<bool> AddUser(AppUser user)
        {
            IdentityResult result = await _manager.CreateAsync(user, user.PasswordHash);
            if (result.Succeeded) return true;
            return false;
        }
    }
}
