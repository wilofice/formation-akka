using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Akka.TeamsService.Domain.TeamsAggregate.Abstractions;
using Akka.TeamsService.Domain.TeamsAggregate.Models;
using Akka.TeamsService.Infrastructure.TeamsAggregate.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Akka.TeamsService.Api.Controllers
{
    [ApiController]
    public class TeamsController : Controller
    {
        private ITeamsReadRepository _teamsRepository;

        public TeamsController(ITeamsReadRepository teamsReadRepository)
        {
            _teamsRepository = teamsReadRepository;
        }
        
        [HttpGet]
        [Route("/api/teams")]
        public IActionResult GetAllTeams()
        {
            return Ok(_teamsRepository.GetAllTeams());
        }
    }
}