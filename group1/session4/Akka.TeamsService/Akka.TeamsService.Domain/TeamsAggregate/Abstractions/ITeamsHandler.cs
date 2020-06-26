using Akka.TeamsService.Domain.TeamsAggregate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Akka.TeamsService.Domain.TeamsAggregate.Abstractions
{
    public interface ITeamsHandler
    {
        Team CreateTeam(string name, string description, List<Person> members);
        bool AddMemberToTeam(Person member);

        bool UpdateTeam(Team team);

        bool DeleteTeam(Team team);

    }
}
