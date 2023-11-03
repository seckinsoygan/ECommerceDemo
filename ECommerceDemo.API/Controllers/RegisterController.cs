using ECommerceDemo.API.Models.AppUsers.RequestModels;
using ECommerceDemo.BLL.Abstract;
using ECommerceDemo.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public RegisterController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        [HttpPost]
        public async Task<IActionResult> RegisterUser(UserRegisterViewModel model)
        {
            AppUser appUser = new()
            {
                UserName = model.Username,
                Email = model.Email,
                PasswordHash = model.Password
            };
            bool result = await _appUserService.CreateUserAsync(appUser);
            if (result)
            {
                return Ok("Kullanıcı ekleme başarılıdır.");
            }
            return BadRequest("Bir sorunla karşılaşıldı.");
        }
    }
}
