using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace shipment_api.Labels.Queries
{
    public class GetLabelQuery : IRequest<LabelViewModel>
    {
        public GetLabelQuery(string trackingNumber)
        {
            TrackingNumber = trackingNumber;
        }
        public string TrackingNumber { get; init; }
    }
    public class GetLabelQueryHandler : IRequestHandler<GetLabelQuery, LabelViewModel>
    {
        public Task<LabelViewModel> Handle(GetLabelQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
