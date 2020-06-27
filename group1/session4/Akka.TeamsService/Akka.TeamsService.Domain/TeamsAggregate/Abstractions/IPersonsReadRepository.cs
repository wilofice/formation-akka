using Akka.TeamsService.Domain.TeamsAggregate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Akka.TeamsService.Domain.TeamsAggregate.Abstractions
{
    public interface IPersonsReadRepository
    {
        IPersonDto GetPersonById(string id);
    }
}
