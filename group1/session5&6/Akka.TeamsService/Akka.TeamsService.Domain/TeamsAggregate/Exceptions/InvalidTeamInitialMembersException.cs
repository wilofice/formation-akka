using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Akka.TeamsService.Domain.TeamsAggregate.Exceptions
{
    public class InvalidTeamInitialMembersException : BusinessException
    {
        public InvalidTeamInitialMembersException()
        {
        }

        public InvalidTeamInitialMembersException(string message) : base(message)
        {
        }

        public InvalidTeamInitialMembersException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidTeamInitialMembersException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
