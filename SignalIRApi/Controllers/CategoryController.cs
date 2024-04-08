using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;

namespace SignalIRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult CategoryList() 
        {
            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCategory(CrealteCategoryDto crealteCategoryDto)
        {
            _categoryService.TAdd(new Category()
            {
                CategoryName = crealteCategoryDto.CategoryName,
                Status=true
            });
            return Ok("Category Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id) 
        {
            var value=_categoryService.TGetById(id);
            _categoryService.TDelete(value);
            return Ok("Category Silindi");
        }
        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id) 
        {
        
            var value=_categoryService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateCategory(UptadateCategoryDto uptadateCategoryDto)
        {
            _categoryService.TUpdate(new Category()
            {
                CategoryID = uptadateCategoryDto.CategoryID,
                CategoryName = uptadateCategoryDto.CategoryName,
                Status = uptadateCategoryDto.Status
            });
            return Ok("Category Güncellendi");
        }
      
    }
}
