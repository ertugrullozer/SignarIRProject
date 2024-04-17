using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.BusinessLayer.Concrete;
using SıgnalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.ProductDto;

namespace SignalIRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);
        }

        //category isimli mettot listesi
        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory() 
        {
            var context = new SignalRContext();
            var value = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
            {
                ProductID = y.ProductID,
                CategoryName = y.ProductName,
                Description = y.Description,
                ImageUrl = y.ImageUrl,
                ProductName = y.ProductName,
                Price = y.Price,
                ProductStatus = y.ProductStatus
            }).ToList();
            return Ok(value);
        
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                Description = createProductDto.Description,
                ImageUrl = createProductDto.ImageUrl,
                Price = createProductDto.Price,
                ProductName = createProductDto.ProductName,
                ProductStatus = createProductDto.ProductStatus
            });
            return Ok("Product Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id) 
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return Ok("Product Silindi");
        }

        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id) 
        { 
            var value= _productService.TGetById(id);
            return Ok(value);
        
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product() 
            { 
                ProductID = updateProductDto.ProductID,
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,   
                Price = updateProductDto.Price,
                ProductName = updateProductDto.ProductName,
                ProductStatus = updateProductDto.ProductStatus

                
            });
            return Ok("Product Güncellendi");
        }
    }
}
