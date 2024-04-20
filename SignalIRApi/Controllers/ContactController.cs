using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.BusinessLayer.Concrete;
using SignalR.DtoLayer.ContactDto;

namespace SignalIRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService,IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateCantactDto contact)
        {
            _contactService.TAdd(new Contact()
            {
                
                FooterDesctiption = contact.FooterDesctiption,
                Location = contact.Location,
                Mail = contact.Mail,
                Phone = contact.Phone,
            });
            return Ok("Contact Eklendi");
        }
		[HttpDelete("{id}")]
		public IActionResult DeleteContact(int id)
		{
			var value = _contactService.TGetById(id);
			_contactService.TDelete(value);
			return Ok("Contact Silindi");

		}

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto update)
        {
            _contactService.TUpdate(new Contact()
            {
                ContactID=update.ContactID,
                FooterDesctiption=update.FooterDesctiption,
                Location=update.Location,
                Mail = update.Mail,
                Phone = update.Phone
            });
            return Ok("Contact Güncellendi");
        }
    }
}
