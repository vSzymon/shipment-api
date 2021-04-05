using shipment_api.Domain.ValueObjects;
using System.Collections.Generic;

namespace shipment_api.Domain.Enitites
{
    public record Shipper
    {
        public string ShipperId { get; init; }
        public Address Address { get; init; }
        public string CompanyName { get; init; }
        public string PersonName { get; init; }
        public EmailAddress EmailAddress { get; init; }

        public ICollection<Package> Packages { get; init; }
    }
}
