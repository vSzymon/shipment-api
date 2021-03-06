using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shipment_api.Domain.Exceptions
{
    public class InvalidEmailAddressException : Exception
    {
        public InvalidEmailAddressException() : base()
        {

        }
        public InvalidEmailAddressException(string message) : base(message)
        {

        }
        public InvalidEmailAddressException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
