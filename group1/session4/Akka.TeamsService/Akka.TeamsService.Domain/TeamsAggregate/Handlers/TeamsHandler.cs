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


        public bool AddMemberToTeam(AddMemberToTeamRequest requet)
        {
            throw new NotImplementedException();
        }

        public bool CreateTeam(CreateTeamRequest createTeamRequest)
        {
            Person person = _personsRepository.GetPersonById(createTeamRequest.PersonId);

            if (person == null)
            {
                throw new PersonNotFoundException("Person must exists before creating team", new InvalidOperationException());
            }

            Team team = _teamsReadRepository.GetTeamById(createTeamRequest.Id);

            if (team != null)
            {
                throw new DuplicateTeamIdentifierException("Team Id already exist", new InvalidOperationException());
            }

            team = Team.CreateTeam(createTeamRequest.Id, createTeamRequest.Name, ..., new List<Person> { person }));

            return team != null;
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
