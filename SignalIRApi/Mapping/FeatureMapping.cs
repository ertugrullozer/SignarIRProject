using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.DtoLayer.FeatureDto;

namespace SignalIRApi.Mapping
{
    public class FeatureMapping:Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature,ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature,GetFeatureDto>().ReverseMap();
            CreateMap<Feature,UpdateFeatureDto>().ReverseMap();
        }
    }
}
