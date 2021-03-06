using shipment_api.Domain.Enums;

namespace shipment_api.Domain.Enitites
{
    public record Product
    {
        public string Id { get; init; }
        public string Name { get; init; }
        public decimal Quantity { get; init; }
        public decimal Weight { get; init; }
        public WeightUnit WeightUnit { get; init; }
    }
}
