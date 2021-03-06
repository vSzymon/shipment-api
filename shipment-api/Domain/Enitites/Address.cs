namespace shipment_api.Domain.Enitites
{
    public record Address
    {
        public string Country { get; init; }
        public string City { get; init; }
        public string StreetLine { get; init; }
        public string ZipCode { get; init; }
        public bool IsAccessPoint { get; init; }
    }
}
