using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.DtoLayer.AboutDto;

namespace SignalIRApi.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
           CreateMap<About,ResultAboutDto>().ReverseMap();
           CreateMap<About,CreateAboutDto>().ReverseMap();
           CreateMap<About,GetAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
        }
    }
}
