using AutoMapper;
using MacsBusinessManagementWebApp.Data.Entities;
using MacsBusinessManagementWebApp.Data.Products.CreateProduct;
using MacsBusinessManagementWebApp.Data.Products.DeleteProduct;
using MacsBusinessManagementWebApp.Data.Products.UpdateProduct;

namespace MacsBusinessManagementWebApp.Infrastructure.AutoMapper
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
