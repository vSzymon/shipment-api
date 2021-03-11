using shipment_api.Domain.Enums;
using shipment_api.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValueOf;

namespace shipment_api.Domain.ValueObjects
{
    public class Weight : ValueOf<(float, WeightUnit), Weight>
    {
        protected override void Validate()
        {
            if (Value.Item1 < 0) 
            {
                throw new InvalidWeightException(Value.Item1);
            }
        }
        public override int GetHashCode()
        {
            return Value.Item1.GetHashCode() + Value.Item2.GetHashCode();
        }
    }
}
