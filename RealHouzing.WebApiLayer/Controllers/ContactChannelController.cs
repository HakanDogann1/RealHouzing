using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.ContactChannelDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactChannelController : ControllerBase
    {
        private readonly IContactChannelService _contactChannelService;

        public ContactChannelController(IContactChannelService contactChannelService)
        {
            _contactChannelService = contactChannelService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var values = _contactChannelService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddContactChannel(ResultContactChannelDto contactChannelDto)
        {
            ContactChannel contactChannel = new ContactChannel()
            {
                ContactChannelDescription = contactChannelDto.ContactChannelDescription,
                ContactChannelTitle = contactChannelDto.ContactChannelTitle,
                Icon = contactChannelDto.Icon,
            };
            _contactChannelService.TInsert(contactChannel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContactChannel(int id)
        {
            var value = _contactChannelService.TGetById(id);
            _contactChannelService.TDelete(value);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetContactChannel(int id)
        {
            var value = _contactChannelService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateContactChannel(UpdateContactChannelDto contactChannelDto)
        {
            ContactChannel contactChannel = new ContactChannel()
            {
                ContactChannelDescription = contactChannelDto.ContactChannelDescription,
                ContactChannelID = contactChannelDto.ContactChannelID,
                Icon = contactChannelDto.Icon,
                ContactChannelTitle = contactChannelDto.ContactChannelTitle,
            };
            _contactChannelService.TUpdate(contactChannel);
            return Ok();
        }
    }
}
