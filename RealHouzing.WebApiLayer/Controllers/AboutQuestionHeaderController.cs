using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutHeader;
using RealHouzing.DtoLayer.AboutQuestionHeaderDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutQuestionHeaderController : ControllerBase
    {

        private readonly IAboutQuestionHeaderService _aboutQuestionHeaderService;
        private readonly IMapper _mapper;

        public AboutQuestionHeaderController(IAboutQuestionHeaderService aboutQuestionHeaderService, IMapper mapper)
        {
            _aboutQuestionHeaderService = aboutQuestionHeaderService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var values = _aboutQuestionHeaderService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAboutHeader(ResultAboutQuestionHeaderDto addAboutQuestionHeaderDto)
        {
            var value = _mapper.Map<AboutQuestionHeader>(addAboutQuestionHeaderDto);
            _aboutQuestionHeaderService.TInsert(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAboutHeader(UpdateAboutQuestionHeaderDto updateAboutHeaderDto)
        {
            var value = _mapper.Map<AboutQuestionHeader>(updateAboutHeaderDto);
            _aboutQuestionHeaderService.TUpdate(value);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAboutHeader(int id)
        {
            var value = _aboutQuestionHeaderService.TGetById(id);
            _aboutQuestionHeaderService.TDelete(value);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _aboutQuestionHeaderService.TGetById(id);
            return Ok(value);
        }
    }
}
