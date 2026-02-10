using AutoMapper;
using BusinessManagementWebApp.Data.Entities;
using BusinessManagementWebApp.Data.Products.CreateProduct;
using BusinessManagementWebApp.Data.Products.DeleteProduct;
using BusinessManagementWebApp.Data.Products.UpdateProduct;

namespace BusinessManagementWebApp.Infrastructure.AutoMapper
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
