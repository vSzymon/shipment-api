namespace shipment_api.Domain.ValueObjects
{
    public record Address
    {
        public string Country { get; init; }
        public string City { get; init; }
        public string Street { get; init; }
        public ZipCode ZipCode { get; init; }
        public bool IsAccessPoint { get; init; }
    }
}
