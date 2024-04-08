using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.ContactDto;

namespace SignalIRApi.Mapping
{
    public class ContactMapping:Profile
        
    {
        public ContactMapping()
        {
            CreateMap<Contact,ResultContactDto>().ReverseMap();
            CreateMap<Contact,CreateCantactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
        }
    }
}
