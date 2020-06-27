using System;
using System.Collections.Generic;
using System.Text;

namespace Akka.TeamsService.Domain.TeamsAggregate.Abstractions.Dtos
{
    public interface IPersonToTeamDto
    {
        string TeamId { get; set; }
        string PersonId { get; set; }
    }
}
