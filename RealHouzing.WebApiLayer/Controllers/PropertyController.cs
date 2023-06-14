using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.ProductDtos;
using RealHouzing.DtoLayer.PropertyDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyService _propertyService;

        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var values = _propertyService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddProperty(ResultPropertyDto resultPropertyDto)
        {
            Property property = new Property()
            {
                ImageUrl = resultPropertyDto.ImageUrl,
                PropertyTitle = resultPropertyDto.PropertyTitle
            };
            _propertyService.TInsert(property);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProperty(int id)
        {
            var value = _propertyService.TGetById(id);
            _propertyService.TDelete(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetProperty(int id)
        {
            var value = _propertyService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateProperty(UpdatePropertyDto updatePropertyDto)
        {
            Property property = new Property()
            {
                ImageUrl = updatePropertyDto.ImageUrl,
                PropertyTitle = updatePropertyDto.PropertyTitle,
                PropertyID = updatePropertyDto.PropertyID
            };
            _propertyService.TUpdate(property);
            return Ok();
        }
    }
}
