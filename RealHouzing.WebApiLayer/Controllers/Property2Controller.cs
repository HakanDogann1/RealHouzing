using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.Property2Dtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Property2Controller : ControllerBase
    {
        private readonly IProperty2Service _property2Service;

        public Property2Controller(IProperty2Service property2Service)
        {
            _property2Service = property2Service;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var values = _property2Service.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddProperty2(ResultProperty2Dto resultProperty2Dto)
        {
            Property2 property2 = new Property2()
            {
                ImageUrl = resultProperty2Dto.ImageUrl,
                Property2Title = resultProperty2Dto.Property2Title,
            };
            _property2Service.TInsert(property2);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProperty2(int id)
        {
            var value=_property2Service.TGetById(id);
            _property2Service.TDelete(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _property2Service.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateProperty2(UpdateProperty2Dto updateProperty2Dto)
        {
            Property2 property2 = new Property2()
            {
                ImageUrl = updateProperty2Dto.ImageUrl,
                Property2ID = updateProperty2Dto.Property2ID,
                Property2Title = updateProperty2Dto.Property2Title,
            };
            _property2Service.TUpdate(property2);
            return Ok();
        }
    }
}
