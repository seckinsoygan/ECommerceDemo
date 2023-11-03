namespace ECommerceDemo.API.Models.Products.RequestModels
{
    public class CreateProductModel
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }
    }
}
