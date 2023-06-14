using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutHeader;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutHeaderController : ControllerBase
    {
        private readonly IAboutHeaderService _aboutHeaderService;
        private readonly IMapper _mapper;

        public AboutHeaderController(IAboutHeaderService aboutHeaderService, IMapper mapper)
        {
            _aboutHeaderService = aboutHeaderService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var values = _aboutHeaderService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAboutHeader(AddAboutHeaderDto addAboutHeaderDto)
        {
            var value = _mapper.Map<AboutHeader>(addAboutHeaderDto);
            _aboutHeaderService.TInsert(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAboutHeader(UpdateAboutHeaderDto updateAboutHeaderDto)
        {
            var value = _mapper.Map<AboutHeader>(updateAboutHeaderDto);
            _aboutHeaderService.TUpdate(value);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAboutHeader(int id)
        {
            var value = _aboutHeaderService.TGetById(id);
            _aboutHeaderService.TDelete(value);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _aboutHeaderService.TGetById(id);
            return Ok(value);
        }
       
    }
}
