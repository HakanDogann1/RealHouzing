using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.ContactMapDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactMapController : ControllerBase
    {
        private readonly IContactMapService _contactMapService;

        public ContactMapController(IContactMapService contactMapService)
        {
            _contactMapService = contactMapService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var values = _contactMapService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetContactMap(int id)
        {
            var value = _contactMapService.TGetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddContactMap(ResultContactMapDto resultContactMapDto)
        {
            ContactMap contactMap = new ContactMap()
            {
                ContactLocationName = resultContactMapDto.ContactLocationName,
                ContactMapLocation = resultContactMapDto.ContactMapLocation,
                Status = resultContactMapDto.Status,
            };
            _contactMapService.TUpdate(contactMap);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContactMap(int id)
        {
            var value = _contactMapService.TGetById(id);
            _contactMapService.TDelete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateContactMap(UpdateContactMapDto updateContactMapDto)
        {
            ContactMap contactMap = new ContactMap()
            {
                ContactLocationName = updateContactMapDto.ContactLocationName,
                ContactMapID = updateContactMapDto.ContactMapID,
                Status = updateContactMapDto.Status,
                ContactMapLocation = updateContactMapDto.ContactMapLocation,
            };
            _contactMapService.TUpdate(contactMap);
            return Ok();
        }
        [HttpPost("{id}")]
        public IActionResult AktifContactMap(int id)
        {
            var value = _contactMapService.TGetById(id);
            value.Status = true;
            _contactMapService.TUpdate(value);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult PasifContactMap(int id)
        {
            var value = _contactMapService.TGetById(id);
            value.Status = false;
            _contactMapService.TUpdate(value);
            return Ok();
        }
    }
}
