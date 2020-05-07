using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Akka.TeamsService.Domain.TeamsAggregate.Abstractions;
using Akka.TeamsService.Domain.TeamsAggregate.Models;
using Akka.TeamsService.Infrastructure.TeamsAggregate.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace Akka.TeamsService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : Controller
    {
        private ITeamsReadRepository _teamsRepository;

        public TeamsController(ITeamsReadRepository teamsReadRepository)
        {
            _teamsRepository = teamsReadRepository;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Team>> GetAllTeams()
        {
            return Ok(_teamsRepository.GetAllTeams());
        }

        [HttpGet("hashcode")]
        public IActionResult GetHashcode()
        {
            return Ok(new { value = _teamsRepository.GetHashCode() });
        }
    }
}