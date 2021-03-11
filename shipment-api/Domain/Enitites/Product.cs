using shipment_api.Domain.Enums;
using shipment_api.Domain.ValueObjects;
using System.Collections.Generic;

namespace shipment_api.Domain.Enitites
{
    public record Product
    {
        public string Id { get; init; }
        public string Name { get; init; }
        public Weight TotalWeight { get; init; }
        public ICollection<Package> Products { get; } = new HashSet<Package>();
    }
}
