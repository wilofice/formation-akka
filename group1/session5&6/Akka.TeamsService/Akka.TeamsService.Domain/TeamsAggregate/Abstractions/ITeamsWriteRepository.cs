using Akka.TeamsService.Domain.TeamsAggregate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Akka.TeamsService.Domain.TeamsAggregate.Abstractions
{
    public interface ITeamsWriteRepository
    {
        bool InsertTeam(Team team);
        bool DeleteTeam(Team team);
    }
}
