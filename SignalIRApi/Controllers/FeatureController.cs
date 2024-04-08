using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ContactDto;
using SignalR.DtoLayer.FeatureDto;

namespace SignalIRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult FeatureList()
        {
            var value = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            _featureService.TAdd(new Feature()
            {
                Title1=createFeatureDto.Title1,
                Title2=createFeatureDto.Title2,
                Title3 = createFeatureDto.Title3,
                Description1 = createFeatureDto.Description1,
                Description2 = createFeatureDto.Description2,
                Description4 = createFeatureDto.Description4
              
            });
            return Ok("Feature Eklendi");
        }
        [HttpPost("GetFeature")]
        public IActionResult GetFeature(int id)
        {
            var value = _featureService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetById(id);
            _featureService.TDelete(value);
            return Ok("Feature Silindi");

        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto update)
        {
            _featureService.TUpdate(new Feature()
            {
                FeatureID = update.FeatureID,
                Title1 = update.Title1,
                Title2 = update.Title2,
                Description1 = update.Description1,
                Description2 = update.Description2,
                Description4= update.Description4
                
            });
            return Ok("Feature Güncellendi");
        }
    }
}
