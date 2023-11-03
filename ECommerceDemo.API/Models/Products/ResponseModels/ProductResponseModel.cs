namespace ECommerceDemo.API.Models.Products.ResponseModels
{
    public class ProductResponseModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string CategoryName { get; set; }
    }
}
