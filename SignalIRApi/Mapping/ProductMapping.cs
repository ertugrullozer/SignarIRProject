using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.DtoLayer.ProductDto;

namespace SignalIRApi.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product,CreateProductDto>().ReverseMap();
            CreateMap<Product,GetProductDto>().ReverseMap();
            CreateMap<Product,UpdateProductDto>().ReverseMap();
        }
    }
}
