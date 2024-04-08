using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.DtoLayer.DiscountDto;

namespace SignalIRApi.Mapping
{
    public class DiscountMapping:Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount,ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
            CreateMap<Discount, GetDiccountDto>().ReverseMap();
            CreateMap<Discount,UpdateDiscontDto>().ReverseMap();
        }
    }
}
