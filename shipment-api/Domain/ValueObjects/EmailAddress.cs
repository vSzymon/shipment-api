using shipment_api.Domain.Exceptions;
using System;
using System.Text.RegularExpressions;
using ValueOf;
namespace shipment_api.Domain.ValueObjects
{
    public class EmailAddress : ValueOf<string, EmailAddress>
    {
        protected override void Validate()
        {
            try
            {
                var regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@
               ((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                RegexOptions.CultureInvariant | RegexOptions.Singleline);

                if (regex.IsMatch(Value) == false) 
                {
                    throw new InvalidEmailAddressException(Value);
                }
            }
            catch (ArgumentNullException)
            {
                throw new InvalidEmailAddressException(Value);
            }
            catch (RegexMatchTimeoutException) 
            {
                throw new InvalidEmailAddressException(Value);
            }
        }
    }
}
