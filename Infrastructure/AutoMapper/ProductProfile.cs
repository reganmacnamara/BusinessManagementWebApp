using AutoMapper;
using InvoiceAutomationWebApp.Data.Products.CreateProduct;
using InvoiceAutomationWebApp.Data.Products.DeleteProduct;
using InvoiceAutomationWebApp.Data.Products.Entities;
using InvoiceAutomationWebApp.Data.Products.UpdateProduct;

namespace InvoiceAutomationWebApp.Infrastructure.AutoMapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, CreateProductRequest>();
            CreateMap<Product, DeleteProductRequest>();
            CreateMap<Product, UpdateProductRequest>();
        }
    }
}
