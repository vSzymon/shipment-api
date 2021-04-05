using System;
using System.Collections.Generic;

namespace shipment_api.Domain.Enitites
{
    public record Package
    {
        public string PackageId { get; init; }
        public string CustomerId { get; init; }
        public string ShipperId { get; init; }
        public string LabelId { get; init; }
        public DateTime Created { get; init; }
        public DateTime Shipped { get; init; }
        public string TrackingNumber { get; init; }
        
        public Shipper Shipper { get; init; }
        public Customer Customer { get; init; }
        public Label Label { get; set; }
        public ICollection<Product> Products { get; } = new HashSet<Product>();
    }
}
