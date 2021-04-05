using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shipment_api.Common.Interfaces
{
    public interface IDateTime
    {
        public DateTime Now { get; }
    }
}
