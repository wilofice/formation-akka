using System;
using System.Collections.Generic;
using System.Text;

namespace Akka.TeamsService.Domain.TeamsAggregate.Models
{
    public class Result<T>
    {
        public string ErrorMessage { get; private set; }
        public string PropertyName { get; private set; }

        public T value { get; private set; }


        public static Result<T> Fail(string errorMessage, string propertyName)
        {
            return new Result<T>
            {
                ErrorMessage = errorMessage
            };
        }


        public static Result<T> OK(T val)
        {
            return new Result<T>
            {
                value = val
            };
        }
    }
}
