using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutQuestionDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutQuestionController : ControllerBase
    {
        private readonly IAboutQuestionService _aboutQuestionService;
        private readonly IMapper _mapper;

        public AboutQuestionController(IAboutQuestionService aboutQuestionService, IMapper mapper)
        {
            _aboutQuestionService = aboutQuestionService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var values = _aboutQuestionService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAboutQuestion(ResultAboutQuestionDto resultAboutQuestionDto)
        {
            var result = _mapper.Map<AboutQuestion>(resultAboutQuestionDto);
            _aboutQuestionService.TInsert(result);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAboutQuestion(UpdateAboutQuestionDto updateAboutQuestionDto)
        {
            var value = _mapper.Map<AboutQuestion>(updateAboutQuestionDto);
            _aboutQuestionService.TUpdate(value);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAboutQuestion(int id)
        {
            var value = _aboutQuestionService.TGetById(id);
            _aboutQuestionService.TDelete(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetAboutQuestion(int id)
        {
            var value = _aboutQuestionService.TGetById(id);
            return Ok(value);
        }

    }
}
