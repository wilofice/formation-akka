using Akka.TeamsService.Domain.TeamsAggregate.Abstractions;
using Akka.TeamsService.Domain.TeamsAggregate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Akka.TeamsService.Infrastructure.TeamsAggregate.Repositories
{
    public class TeamsRepository : ITeamsReadRepository
    {
        public IEnumerable<Team> GetAllTeams()
        {
            return new List<Team> { 
                new Team
                {
                    Id = 1,
                    Name = "ITCommerce",
                    Description = "Commerce"
                }
            };
        }
    }
}
