﻿using ECommerceDemo.Entities.Concrete;

namespace ECommerceDemo.DAL.Repositories.Abstract
{
    public interface IAppUserRepository : IRepository<AppUser>
    {
        Task<bool> AddUser(AppUser user);
    }
}
