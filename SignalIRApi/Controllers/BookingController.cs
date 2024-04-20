using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.BookingDto;

namespace SignalIRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
               Name = createBookingDto.Name,
               Mail=createBookingDto.Mail,
               PersonelCount=createBookingDto.PersonelCount,
                Phone = createBookingDto.Phone,
                Date = createBookingDto.Date
            };
            _bookingService.TAdd(booking);   
            return Ok("Booking kısmı Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id) 
        {
            var value=_bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok("Boking Silindi");
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            { 
                BookingID = updateBookingDto.BookingID,
                Name = updateBookingDto.Name, 
                Mail = updateBookingDto.Mail,
                Date = updateBookingDto.Date,
                PersonelCount = updateBookingDto.PersonelCount,
                Phone= updateBookingDto.Phone
                
            
            };
            _bookingService.TUpdate(booking);
            return Ok("Booking Tablosu Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id) 
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }
    }
}
