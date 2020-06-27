using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Akka.TeamsService.Domain.TeamsAggregate.Exceptions
{
    public class TeamCreationFailedException : BusinessException
    {
        public TeamCreationFailedException()
        {
        }

        public TeamCreationFailedException(string message) : base(message)
        {
        }

        public TeamCreationFailedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TeamCreationFailedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
