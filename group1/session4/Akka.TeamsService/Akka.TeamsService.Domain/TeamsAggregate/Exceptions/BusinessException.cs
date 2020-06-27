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
            { typeof(DuplicateTeamIdentifierException), typeof(ConflictObjectResult)},
        };

        
        public static ObjectResult GetStatusCodeResult(BusinessException businessException)
        {
            Type type = ExceptionManagement[businessException.GetType()];

            ConstructorInfo[] ctors = type.GetConstructors(BindingFlags.Public);

            var objResult = (ObjectResult)ctors[0].Invoke(new object[] { businessException.Message });

            return objResult;
        }

    }
}
