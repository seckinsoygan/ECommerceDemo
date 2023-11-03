using ECommerceDemo.API.Models.Categories.RequestModels;
using ECommerceDemo.API.Models.Categories.ResponseModels;
using ECommerceDemo.BLL.Abstract;
using ECommerceDemo.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryModel model)
        {
            Category c = new()
            {
                CategoryName = model.CategoryName,
                Description = model.Description,
            };
            var result = categoryService.AddAsync(c);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            List<Category> categories = categoryService.GetAllAsync().ToList();
            List<CategoryResponseModel> response = new();
            foreach (var category in categories)
            {
                CategoryResponseModel model = new()
                {
                    CategoryName = category.CategoryName,
                    Description = category.Description,
                    CategoryId = category.Id
                };
                response.Add(model);
            }
            return Ok(response);
        }
    }
}
