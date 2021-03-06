using shipment_api.Domain.ValueObjects;

namespace shipment_api.Domain.Enitites
{
    public record Shipper
    {
        public string Id { get; init; }
        public Address Address { get; init; }
        public string CompanyName { get; init; }
        public string PersonName { get; init; }
        public EmailAddress EmailAddress { get; init; }    
    }
}
