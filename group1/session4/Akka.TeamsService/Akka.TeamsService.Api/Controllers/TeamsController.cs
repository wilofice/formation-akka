using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Akka.TeamsService.Domain.TeamsAggregate.Abstractions;
using Akka.TeamsService.Domain.TeamsAggregate.Models;
using Akka.TeamsService.Infrastructure.TeamsAggregate.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Akka.TeamsService.Domain.TeamsAggregate.Commands;
using Akka.TeamsService.Domain.TeamsAggregate.Exceptions;
using Microsoft.Extensions.Logging;

namespace Akka.TeamsService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : Controller
    {
        private ITeamsReadRepository _teamsRepository;
        private readonly ILogger<TeamsController> _logger;
        private ITeamsHandler _handler;

        public TeamsController(ITeamsReadRepository teamsReadRepository, ILogger<TeamsController> logger)
        {
            _teamsRepository = teamsReadRepository;
            _logger = logger;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Team>> GetAllTeams()
        {
            return Ok(_teamsRepository.GetAllTeams());
        }

        [HttpGet]
        public ActionResult<Team> GetTeam(string id)
        {
            return Ok();
        }



        [HttpPost]
        public ActionResult CreateTeam([FromBody] CreateTeamRequest createTeamRequest)
        {
            try
            {
                bool operationSuccess = _handler.CreateTeam(createTeamRequest);

                return Created("", new { operationSuccess });

            }
            catch (BusinessException e)
            {

                return BusinessException.GetStatusCodeResult(e);
            }
        }
    }
}