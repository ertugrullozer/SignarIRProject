using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.TestimonialDto;

namespace SignalIRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestiMonialController : ControllerBase
    {
        private readonly ITestiMonialService _testiMonialService;
        private readonly IMapper _mapper;

        public TestiMonialController(ITestiMonialService testiMonialService, IMapper mapper)
        {
            _testiMonialService = testiMonialService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult TestimonialList() 
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testiMonialService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CereateTestimonialDto cereateTestimonialDto)
        {
            _testiMonialService.TAdd(new Testimonial()
            {
                Comment = cereateTestimonialDto.Comment,
                ImageUrl= cereateTestimonialDto.ImageUrl,
                Name = cereateTestimonialDto.Name,
                Title = cereateTestimonialDto.Title,
                Status = cereateTestimonialDto.Status
            });
            return Ok("Testimonial Eklendi");
        }
        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var value =_testiMonialService.TGetById(id);
            return Ok(value);

        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id) 
        {
            var value = _testiMonialService.TGetById(id);
            _testiMonialService.TDelete(value);
            return Ok("Testimonial Silme İşlemi");
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testiMonialService.TUpdate(new Testimonial()
            {
                Comment= updateTestimonialDto.Comment,
                ImageUrl = updateTestimonialDto.ImageUrl,
                Name = updateTestimonialDto.Name,
                Status = updateTestimonialDto.Status,
                TestimonialID  =updateTestimonialDto.TestimonialID,
                Title=updateTestimonialDto.Title
               
            });
            return Ok("Testimonial Güncellendi");
        }
    }
}
