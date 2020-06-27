using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Akka.TeamsService.Domain.TeamsAggregate.Abstractions.Dtos;
using Akka.TeamsService.Domain.TeamsAggregate.Exceptions;

namespace Akka.TeamsService.Domain.TeamsAggregate.Models
{
    public class Team
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public IReadOnlyList<Person> Members
        {
            get
            {
                return _members;
            }
        }

        private List<Person> _members = new List<Person>();

        private Team(string id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
            _members = new List<Person>();
        }


        public static Team CreateTeam(string id, string name, string description, IEnumerable<Person> members)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new TeamCreationFailedException("message", new ArgumentNullException(nameof(id)));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new TeamCreationFailedException("message", new ArgumentNullException(nameof(name)));
            }

            if (name.Length < 20)
            {
                throw new TeamCreationFailedException("message", new ArgumentNullException(nameof(name)));
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new TeamCreationFailedException("message", new ArgumentNullException(nameof(description)));
            }

            if (description.Length < 20)
            {
                throw new TeamCreationFailedException("message", new ArgumentNullException(nameof(description)));
            }

            if (!(members?.Any() ?? false))
            {
                throw new TeamCreationFailedException("message", new ArgumentException(nameof(members)));
            }

            Team team = new Team(id, name, description)
            {
                _members = members.ToList()
            };

            foreach (Person member in members)
            {
                member.AddTeam(team);
            }

            return team;
        }
    
        public  Team FromDto(ITeamDto teamDto)
        {
            return null;
        }
    
    }
}
