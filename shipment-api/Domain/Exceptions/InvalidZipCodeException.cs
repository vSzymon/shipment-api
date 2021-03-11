using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shipment_api.Domain.Exceptions
{
    public class InvalidZipCodeException : Exception
    {
        public InvalidZipCodeException(string zipCode)
            : base($"Zip code is in invalid format, current value: {zipCode}") { }
        
    }
}
