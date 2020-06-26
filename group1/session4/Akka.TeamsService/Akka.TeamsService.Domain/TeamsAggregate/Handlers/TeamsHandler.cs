using Akka.TeamsService.Domain.TeamsAggregate.Abstractions;
using Akka.TeamsService.Domain.TeamsAggregate.Commands;
using Akka.TeamsService.Domain.TeamsAggregate.Exceptions;
using Akka.TeamsService.Domain.TeamsAggregate.Models;
using System;
using System.Collections.Generic;

namespace Akka.TeamsService.Domain.TeamsAggregate.Handlers
{
    public class TeamsHandler : ITeamsHandler
    {
        private ITeamsReadRepository _teamsReadRepository;
        private ITeamsWriteRepository _teamsWriteRepository;
        private IPersonsReadRepository _personsRepository;

        public bool AddMemberToTeam(Person member)
        {
            throw new NotImplementedException();
        }

        public bool CreateTeam(CreateTeamRequest createTeamRequest)
        {
            Person person = _personsRepository.GetPersonById(createTeamRequest.EmployeeId);

            if(person == null)
            {
                throw new PersonNotFoundException();
            }

            Team team = _teamsReadRepository.GetTeamById(createTeamRequest.Id);

            if(team != null)
            {
                throw new DuplicateTeamIdentifierException();
            }

            team = Team.CreateTeam(createTeamRequest.Id, createTeamRequest.Name, createTeamRequest.Description, new List<Person> { person });

            return _teamsWriteRepository.InsertTeam(team);
        }

        public bool DeleteTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTeam(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
