using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.DtoLayer.CategoryDto;

namespace SignalIRApi.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
                CreateMap<Category,ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CrealteCategoryDto>().ReverseMap();
            CreateMap<Category,GetCategoryDto>().ReverseMap() ;
            CreateMap<Category,UptadateCategoryDto>().ReverseMap();
        }
    }
}
