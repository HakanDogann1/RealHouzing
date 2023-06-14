using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.Property3Dtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Property3Controller : ControllerBase
    {
        private readonly IProperty3Service _property3Service;

        public Property3Controller(IProperty3Service property3Service)
        {
            _property3Service = property3Service;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var values = _property3Service.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddProperty3(ResultProperty3Dto resultProperty3Dto)
        {
            Property3 property3 = new Property3()
            {
                ImageUrl = resultProperty3Dto.ImageUrl,
                Property3Description = resultProperty3Dto.Property3Description,
                Property3Title = resultProperty3Dto.Property3Title,
            };
            _property3Service.TInsert(property3);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProperty3(int id)
        {
            var value = _property3Service.TGetById(id);
            _property3Service.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateProperty3(UpdateProperty3Dto updateProperty3Dto)
        {
            Property3 property3 = new Property3()
            {
                ImageUrl = updateProperty3Dto.ImageUrl,
                Property3Description = updateProperty3Dto.Property3Description,
                Property3ID = updateProperty3Dto.Property3ID,
                Property3Title = updateProperty3Dto.Property3Title,
            };
            _property3Service.TUpdate(property3);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetProperty3(int id)
        {
            var value = _property3Service.TGetById(id);
            return Ok(value);
        }

    }
}
