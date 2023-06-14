using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.ProductDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _productService.TGetList();
            return Ok(values);
        }
        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var values = _productService.TGetProductsWithCategories();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddProduct(ResultProductDto resultProductDto)
        {
            Product product = new Product()
            {
                BathRoomCount = resultProductDto.BathRoomCount,
                CoverImageUrl = resultProductDto.CoverImageUrl,
                ProductPrice = resultProductDto.ProductPrice,
                BedRoomCount = resultProductDto.BedRoomCount,
                CategoryID = resultProductDto.CategoryID,
                ProductAdress = resultProductDto.ProductAdress,
                ProductTitle = resultProductDto.ProductTitle,
                ProductType = resultProductDto.ProductType,
                Square = resultProductDto.Square,
            };
            _productService.TInsert(product);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var values = _productService.TGetById(id);
            _productService.TDelete(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var values = _productService.TGetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            Product product = new Product()
            {
                ProductID = updateProductDto.ProductID,
                BathRoomCount = updateProductDto.BathRoomCount,
                CoverImageUrl = updateProductDto.CoverImageUrl,
                ProductPrice = updateProductDto.ProductPrice,
                BedRoomCount = updateProductDto.BedRoomCount,
                CategoryID = updateProductDto.CategoryID,
                ProductAdress = updateProductDto.ProductAdress,
                ProductTitle = updateProductDto.ProductTitle,
                ProductType = updateProductDto.ProductType,
                Square = updateProductDto.Square,
            };
            _productService.TUpdate(product);
            return Ok();
        }
    }
}
