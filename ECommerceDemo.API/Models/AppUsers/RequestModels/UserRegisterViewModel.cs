﻿namespace ECommerceDemo.API.Models.AppUsers.RequestModels
{
    public class UserRegisterViewModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
