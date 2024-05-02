using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLab_on_boarding.Exceptions
{
    internal class InvalidNumberException : Exception
    {
        private const string Message = "The resulting number is incorrect.";

        public InvalidNumberException() : base(Message)
        {
            
        }

        public InvalidNumberException(Exception innerException) : base(Message, innerException)
        {

        }
    }
}
