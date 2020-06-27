using System;
using System.Collections.Generic;
using System.Text;

namespace Akka.TeamsService.Domain.TeamsAggregate.Abstractions.Dtos
{
    public interface IPersonDto
    {
        string PersonId { get; set; }
        string LastName { get; set; }
        string FirstName { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        string AddressId { get; set; }
    }
}
