using System;
using System.Collections.Generic;
using System.Text;

namespace Akka.TeamsService.Domain.TeamsAggregate.Abstractions.Dtos
{
    public interface ITeamDto
    {
        string Guid { get; set; }
        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }
}
