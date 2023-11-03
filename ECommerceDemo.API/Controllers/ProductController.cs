using ECommerceDemo.API.Models.Products.RequestModels;
using ECommerceDemo.API.Models.Products.ResponseModels;
using ECommerceDemo.BLL.Abstract;
using ECommerceDemo.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductModel model)
        {
            Product p = new()
            {
                ProductName = model.ProductName,
                UnitPrice = model.UnitPrice,
                CategoryId = model.CategoryId,
            };
            await _productService.AddAsync(p);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            List<ProductResponseModel> list = new();
            List<Product> products = _productService.GetAllAsync().ToList();
            foreach (var product in products)
            {
                ProductResponseModel p = new()
                {
                    ProductId = product.Id,
                    ProductName = product.ProductName,
                    UnitPrice = product.UnitPrice,
                    CategoryName = product.Category.CategoryName
                };
                list.Add(p);
            }
            return Ok(list);
        }
    }
}
