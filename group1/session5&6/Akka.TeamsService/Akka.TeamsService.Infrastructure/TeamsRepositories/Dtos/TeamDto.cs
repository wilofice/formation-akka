using Akka.TeamsService.Domain.TeamsAggregate.Abstractions.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Akka.TeamsService.Infrastructure.TeamsRepositories.Dtos
{
    public class TeamDto : ITeamDto
    {
        public string Guid { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
