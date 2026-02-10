using BusinessManagementWebApp.Data.Entities;

namespace BusinessManagementWebApp.Data.Products.GetProducts;

public class GetProductsResponse
{
    public List<Product> Products { get; set; } = [];
}
