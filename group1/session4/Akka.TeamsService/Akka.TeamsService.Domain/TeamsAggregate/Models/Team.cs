using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            if (string.IsNullOrEmpty(name))
            {
                throw new TeamCreationFailedException("message", new ArgumentNullException(nameof(name)));
                throw new ArgumentNullException("name must be not null", nameof(name));
            }

            if (string.IsNullOrEmpty(members))
            {
                throw new InvalidTeamInitialMembersException("description must be not null", nameof(name));
            }

            if (description.Length < 20)
            {
                throw new ArgumentNullException("description must have at least 20 Carateres", nameof(name));
            }

            if (!(members?.Any() ?? false))
            {
                throw new InvalidTeamInitialMembersException("teams must have at least one member");
            }

            Team team = new Team(id, name, description);

            team._members = members.ToList();

            foreach(var member in members)
            {
                member.AddTeam(team);
            }

            return team;


        }
    }
}
