using System;
using System.Collections.Generic;
using System.Text;

namespace Akka.TeamsService.Domain.TeamsAggregate.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
