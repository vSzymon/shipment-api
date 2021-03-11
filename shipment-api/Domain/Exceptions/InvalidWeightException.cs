using shipment_api.Domain.ValueObjects;
using System;

namespace shipment_api.Domain.Exceptions
{
    public class InvalidWeightException : Exception
    {
        public InvalidWeightException(float weight)
            : base($"Weight cannot have negaitve value, current value: {weight}") { }
        
    }
}
