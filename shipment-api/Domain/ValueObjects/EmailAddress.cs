using shipment_api.Domain.Exceptions;
using System;

namespace shipment_api.Domain.ValueObjects
{
    public record EmailAddress
    {
        public string Name { get; init; }
        public string Domain { get; init; }

        public static EmailAddress For(string emailAddress) 
        {
            try
            {
                var name = emailAddress.Substring(0, emailAddress.IndexOf('@'));
                var domain = emailAddress[(emailAddress.IndexOf('@') + 1)..];

                return new EmailAddress
                {
                    Name = name,
                    Domain = domain
                };
            }
            catch (Exception ex)
            {
                throw new InvalidEmailAddressException("Email address is in invalid format", ex);
            }
           
        }
    }
}
