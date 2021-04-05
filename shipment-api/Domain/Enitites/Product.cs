using shipment_api.Domain.Enums;
using shipment_api.Domain.ValueObjects;
using System.Collections.Generic;

namespace shipment_api.Domain.Enitites
{
    public record Product
    {
        public string ProductId { get; init; }
        public string Name { get; init; }
        public string PackageId { get; set; }
        public Weight TotalWeight { get; init; }
        public Package Package { get; init; }
    }
}
