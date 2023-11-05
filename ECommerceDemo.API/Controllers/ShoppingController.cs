using ECommerceDemo.API.ExtensionClasses;
using ECommerceDemo.API.Models.ShoppingTools;
using ECommerceDemo.BLL.Abstract;
using ECommerceDemo.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IOrderService orderService;
        private readonly IOrderDetailService orderDetailService;

        public ShoppingController(IProductService productService, IOrderService orderService, IOrderDetailService orderDetailService)
        {
            this.productService = productService;
            this.orderService = orderService;
            this.orderDetailService = orderDetailService;
        }
        [HttpPost]
        public async Task<IActionResult> AddProductToCart(int id)
        {
            Cart c = HttpContext.Session.GetObject<Cart>("scart") == null ? new Cart() :
                HttpContext.Session.GetObject<Cart>("scart");
            Product productEntity = productService.Get(id);

            CartItem ci = new()
            {
                Id = productEntity.Id,
                Name = productEntity.ProductName,
                Price = productEntity.UnitPrice
            };

            c.AddToCart(ci);
            HttpContext.Session.SetObject("scart", c);
            return Ok($"{ci.Name} isimli ürün sepete eklenmiştir.");
        }
        [HttpGet]
        public async Task<IActionResult> GetCardInfo()
        {
            if (HttpContext.Session.GetObject<Cart>("scart") != null)
            {
                Cart c = HttpContext.Session.GetObject<Cart>("scart");
                return Ok(c);
            }
            return BadRequest("Sepetinizde henüz bir ürün bulunmamaktadır.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCardInfo(int id)
        {
            if (HttpContext.Session.GetObject<Cart>("scart") != null)
            {
                Cart c = HttpContext.Session.GetObject<Cart>("scart");
                c.RemoveFromCart(id);
                HttpContext.Session.SetObject("scart", c);
                return Ok(c);
            }
            else
            {
                return BadRequest("Sepetinizde ürün bulunmamaktadır.")
            }
        }

    }
}
