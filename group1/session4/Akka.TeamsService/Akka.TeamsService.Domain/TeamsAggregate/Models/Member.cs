using System;
using System.Collections.Generic;
using System.Text;

namespace Akka.TeamsService.Domain.TeamsAggregate.Models
{
    public class Person : Person
    {
        public IEnumerable<Team> Teams { get; set; }
        private List<Team> _teams { get; set; } = new List<Team>();

        public void AddTeam(Team team)
        {
            if(team == null)
            {
                throw new ArgumentNullException(nameof(team));
            }

            _teams.Add(team);  
        }
    }
}
