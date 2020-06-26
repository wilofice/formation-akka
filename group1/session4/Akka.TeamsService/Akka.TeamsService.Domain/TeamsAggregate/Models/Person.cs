using System;
using System.Collections.Generic;
using System.Text;

namespace Akka.TeamsService.Domain.TeamsAggregate.Models
{
    public class Person
    {
        public string PersonId { get; private set; }
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public Address Address { get; private set; }

        public IEnumerable<Team> Teams { get { return _teams; }  }
        private List<Team> _teams { get; set; } = new List<Team>();

        public Person AddTeam(Team team)
        {
            if (team == null)
            {
                throw new ArgumentNullException(nameof(team));
            }

            _teams.Add(team);

            return this;
        }
    }
}
