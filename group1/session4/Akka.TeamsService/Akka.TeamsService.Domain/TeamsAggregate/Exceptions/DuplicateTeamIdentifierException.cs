using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Akka.TeamsService.Domain.TeamsAggregate.Exceptions
{
    public class DuplicateTeamIdentifierException : BusinessException
    {
        public DuplicateTeamIdentifierException()
        {
        }

        public DuplicateTeamIdentifierException(string message) : base(message)
        {
        }

        public DuplicateTeamIdentifierException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DuplicateTeamIdentifierException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
