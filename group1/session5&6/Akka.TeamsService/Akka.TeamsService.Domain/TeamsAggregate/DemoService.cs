using Akka.TeamsService.Domain.TeamsAggregate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Akka.TeamsService.Domain.TeamsAggregate
{
    class DemoService
    {
        public Team CreateTeam(string name, strin description, List<Person> members)
        {

            if(string.IsNullOrEmpty(name)) 
            {
                throw new ArgumentNullException(nameof(name));
                return null;

            }


            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentNullException(nameof(name));
                return null;

            }

            if (members.Count )
            {
                throw new ArgumentNullException(nameof(name));
                return null;

            }
            Team team = new Team("lj", "ljlj", null);

            try
            {
                Team team = new Team("lj", "ljlj", null);

            } 
            catch (Exception e)
            {

            }
        }
        public void DoSomeUpdateOperation1()
        {
            Team team = GetTeamById("akkateamhacker");

            UseTeamForSomething(team)

            _repository.UpdateTeam(team);
            // do sometthing team
        }


        public Team GetTeamById(string id)
        {
            Team team = _repository.GetTeamById(id);

            return team;
        }


        public void UseTeamForSomething(Team team)
        {
            team.ID = null;
        }






    }
}
