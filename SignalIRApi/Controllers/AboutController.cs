﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;

namespace SignalIRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult AboutList() 
        {
            var values = _aboutService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            //1.Yöntem
            About about = new About()
            {
                Title=createAboutDto.Title,
                Description=createAboutDto.Description,
                ImageUrl=createAboutDto.ImageUrl
            };
            _aboutService.TAdd(about);
            return Ok("Hakkımda Kısmı Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id) 
        {
         var value=_aboutService.TGetById(id);
         _aboutService.TDelete(value);
            return Ok("Hakkımda Alanı Silindi");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto) 
        {
            About about = new About()
            {
                AboutID = updateAboutDto.AboutID,
                Title = updateAboutDto.Title,
                Description = updateAboutDto.Description,
                ImageUrl = updateAboutDto.ImageUrl,
               
            };

            _aboutService.TUpdate(about);
            return Ok("Hakkımda Alanı Güncellendi");
        }
        [HttpGet("GetAbout")]
        public IActionResult GetAbout(int id) 
        { 
            var value= _aboutService.TGetById(id);
            return Ok(value);
        }
    }
}
