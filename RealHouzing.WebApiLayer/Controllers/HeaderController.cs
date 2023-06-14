using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.HeaderDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeaderController : ControllerBase
    {
        private readonly IHeaderService _headerService;

        public HeaderController(IHeaderService headerService)
        {
            _headerService = headerService;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var values = _headerService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddHeader(ResultHeaderDto resultHeaderDto)
        {
            Header header = new Header()
            {
                HeaderTitle1 = resultHeaderDto.HeaderTitle1,
                HeaderTitle2 = resultHeaderDto.HeaderTitle2,
                ImageUrl = resultHeaderDto.ImageUrl
            };
            _headerService.TInsert(header);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateHeader(UpdateHeaderDto updateHeaderDto)
        {
            Header header = new Header()
            {
                HeaderID = updateHeaderDto.HeaderID,
                HeaderTitle1 = updateHeaderDto.HeaderTitle1,
                HeaderTitle2 = updateHeaderDto.HeaderTitle2,
                ImageUrl = updateHeaderDto.ImageUrl
            };
            _headerService.TUpdate(header);
            return Ok();  
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHeader(int id)
        {
            var value = _headerService.TGetById(id);
            _headerService.TDelete(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetHeader(int id)
        {
            var value = _headerService.TGetById(id);
            return Ok(value);
        }
    }
}
