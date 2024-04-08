using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.DtoLayer.TestimonialDto;

namespace SignalIRApi.Mapping
{
    public class TestimonialMapping:Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial,ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial,CereateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial,GetTetimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
        }
    }
}
