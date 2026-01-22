using InvoiceAutomationWebApp.Data.Products.Entities;

namespace InvoiceAutomationWebApp.Data.Products.GetProducts;

public class GetProductsResponse
{
    public List<Product> Products { get; set; } = [];
}
