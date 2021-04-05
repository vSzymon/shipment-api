using shipment_api.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ValueOf;

namespace shipment_api.Domain.ValueObjects
{
    public class ZipCode : ValueOf<string, ZipCode>
    {
        protected override void Validate()
        {
            try
            {
                var regex = new Regex(@"^([0-9]{2})-(\[[0-9]{3})", RegexOptions.CultureInvariant | RegexOptions.Singleline);

                if (regex.IsMatch(Value) == false)
                {
                    throw new InvalidZipCodeException(Value);
                }
            }
            catch (ArgumentNullException)
            {
                throw new InvalidZipCodeException(Value);
            }
            catch (RegexMatchTimeoutException)
            {
                throw new InvalidZipCodeException(Value);
            }
        }
    }
}
