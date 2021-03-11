using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shipment_api.Domain.Exceptions
{
    public class InvalidEmailAddressException : Exception
    {
        public InvalidEmailAddressException(string emailAddress)
            : base($"Email address is in invalid format, current value: {emailAddress}") { }
        
    }
}
