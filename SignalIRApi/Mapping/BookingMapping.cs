using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.DtoLayer.BookingDto;

namespace SignalIRApi.Mapping
{
    public class BookingMapping:Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking,ResultBookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            CreateMap<Booking,UpdateBookingDto>().ReverseMap();
        }
    }
}
