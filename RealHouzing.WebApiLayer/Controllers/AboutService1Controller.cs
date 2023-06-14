using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutService1Dtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutService1Controller : ControllerBase
    {
        private readonly IAboutService1Service _aboutService1;

        public AboutService1Controller(IAboutService1Service aboutService1)
        {
            _aboutService1 = aboutService1;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var values = _aboutService1.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetAboutService(int id)
        {
            var value = _aboutService1.TGetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddAboutService(ResultAboutService1Dto resultAboutService1Dto)
        {
            AboutService1 aboutService1 = new AboutService1()
            {
                AboutService1Description = resultAboutService1Dto.AboutService1Description,
                AboutService1Title = resultAboutService1Dto.AboutService1Title,
                ImageUrl = resultAboutService1Dto.ImageUrl,
            };
            _aboutService1.TInsert(aboutService1);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAboutService(UpdateAboutService1Dto updateAboutService1Dto)
        {
            AboutService1 aboutService1 = new AboutService1()
            {
                AboutService1Description = updateAboutService1Dto.AboutService1Description,
                AboutService1Title = updateAboutService1Dto.AboutService1Title,
                ImageUrl = updateAboutService1Dto.ImageUrl,
                AboutService1ID=updateAboutService1Dto.AboutService1ID
            };
            _aboutService1.TUpdate(aboutService1);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAboutService(int id)
        {
            var value = _aboutService1.TGetById(id);
            _aboutService1.TDelete(value);
            return Ok();
        }
    }
}
