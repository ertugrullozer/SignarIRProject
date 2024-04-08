using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.DiscountDto;

namespace SignalIRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;
        public DiscountController(IDiscountService discountService,IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult DiscountList() 
        { 
            var value=_mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto create)
        {
            _discountService.TAdd(new Discount()
            {
                Amount = create.Amount,
                Description = create.Description,
                ImageUrl = create.ImageUrl,
                Title = create.Title
            });
            return Ok("Discount Eklendi");
        }
        [HttpPost("GetDiscount")]
        public  IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            return Ok(value);

        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscontDto update)
        {
            _discountService.TUpdate(new Discount()
            {
                DiscountID= update.DiscountID,
                Amount= update.Amount,
                Description= update.Description,
                ImageUrl    = update.ImageUrl,
                Title = update.Title
            });
            return Ok("Discount Güncellendi");
        }

        [HttpDelete]
        public IActionResult DeleteDiscount(int id) 
        {
            var value = _discountService.TGetById(id);
            _discountService.TDelete(value);
            return Ok("Discout Silindi");
        
        }
    }
}
