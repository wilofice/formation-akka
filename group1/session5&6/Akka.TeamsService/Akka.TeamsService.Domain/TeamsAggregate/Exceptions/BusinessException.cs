using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace Akka.TeamsService.Domain.TeamsAggregate.Exceptions
{
    public class BusinessException : Exception
    {
        public BusinessException()
        {
        }

        public BusinessException(string message) : base(message)
        {
        }

        public BusinessException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BusinessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        private static Dictionary<Type, Type> ExceptionManagement = new Dictionary<Type, Type>
        {
            { typeof(InvalidTeamInitialMembersException), typeof(NotFoundObjectResult) },
            { typeof(InvalidTeamInitialMembersException), typeof(BadRequestObjectResult) },
            { typeof(InvalidTeamInitialMembersException), typeof(ConflictObjectResult) },
        };

        public static StatusCodeResult GetStatusCodeResult(BusinessException exception)
        {
            Type type = ExceptionManagement[exception.GetType()];

            var ctors = type.GetConstructors(BindingFlags.Public);

            StatusCodeResult obj = (StatusCodeResult) ctors[0].Invoke(new object[] { exception.Message });

            return obj;
        }

    }
}
