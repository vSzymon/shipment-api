﻿using System;
using System.Collections.Generic;

namespace shipment_api.Domain.Enitites
{
    public record Package
    {
        public string Id { get; init; }
        public string CustomerId { get; set; }
        public string ShipperId { get; set; }
        public DateTime Created { get; init; }
        public DateTime Shipped { get; init; }
        public string TrackingNumber { get; init; }
        
        public Shipper Shipper { get; init; }
        public Customer Customer { get; init; }
        public ICollection<Product> Products { get; } = new HashSet<Product>();
    }
}
