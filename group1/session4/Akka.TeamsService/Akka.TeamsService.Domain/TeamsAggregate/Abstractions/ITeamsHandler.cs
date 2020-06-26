using Akka.TeamsService.Domain.TeamsAggregate.Commands;
using Akka.TeamsService.Domain.TeamsAggregate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Akka.TeamsService.Domain.TeamsAggregate.Abstractions
{
    public interface ITeamsHandler
    {
        bool CreateTeam(CreateTeamRequest createTeamRequest);
        bool AddMemberToTeam(Person member, Team team);

        bool UpdateTeam(Team team);

        bool DeleteTeam(Team team);

    }
}
