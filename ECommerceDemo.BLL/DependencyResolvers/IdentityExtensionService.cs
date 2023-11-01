using ECommerceDemo.DAL.Context;
using ECommerceDemo.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceDemo.BLL.DependencyResolvers
{
    public static class IdentityExtensionService
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, IdentityRole<int>>(x =>
            {
                x.Password.RequiredUniqueChars = 0;
                x.Password.RequiredLength = 8;
            }).AddEntityFrameworkStores<AppDbContext>();

            return services;
        }
    }
}
