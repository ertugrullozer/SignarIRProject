using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SocialMediaDto;

namespace SignalIRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaservice;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaservice, IMapper mapper)
        {
            _socialMediaservice = socialMediaservice;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult SocialMediaList() 
        {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaservice.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto socialMediaDto)
        {
            _socialMediaservice.TAdd(new SocialMedia()
            {
                Title = socialMediaDto.Title,
                Icon= socialMediaDto.Icon,
                Url = socialMediaDto.Url,
            });
            return Ok("SocialMedia Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id) 
        { 
            var value = _socialMediaservice.TGetById(id);
            _socialMediaservice.TDelete(value);
            return Ok(value);
        }
        [HttpPost("GetSocialMedia")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaservice.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            _socialMediaservice.TUpdate(new SocialMedia()
            {
                SocialMediaID = updateSocialMediaDto.SocialMediaID,
                Title = updateSocialMediaDto.Title,
                Icon = updateSocialMediaDto.Icon,
                Url = updateSocialMediaDto.Url,
            }); return Ok("SocialMedia Güncellendi");
        }
    }
}
