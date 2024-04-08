using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.DtoLayer.SocialMediaDto;

namespace SignalIRApi.Mapping
{
    public class SocialMediaMapping:Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia,ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,GetSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,UpdateSocialMediaDto>().ReverseMap();
        }
    }
}
