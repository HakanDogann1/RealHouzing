using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.TeamDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var values = _teamService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddTeam(ResultTeamDto resultTeamDto)
        {
            Team team = new Team()
            {
                ImageUrl = resultTeamDto.ImageUrl,
                NameSurname = resultTeamDto.NameSurname,
                Position = resultTeamDto.Position,
            };
            _teamService.TInsert(team);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTeam(UpdateTeamDto resultTeamDto)
        {
            Team team = new Team()
            {
                TeamID = resultTeamDto.TeamID,
                Position = resultTeamDto.Position,
                ImageUrl = resultTeamDto.ImageUrl,
                NameSurname = resultTeamDto.NameSurname,
            };
            _teamService.TUpdate(team);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTeam(int id)
        {
            var value = _teamService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTeam(int id)
        {
            var value = _teamService.TGetById(id);
            _teamService.TDelete(value);
            return Ok();
        }
    }
}
