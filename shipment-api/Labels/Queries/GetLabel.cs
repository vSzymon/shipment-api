using AutoMapper;
using MediatR;
using shipment_api.Interfaces;
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
        private readonly IShipContext context;
        private readonly IMapper mapper;

        public GetLabelQueryHandler(IShipContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<LabelViewModel> Handle(GetLabelQuery request, CancellationToken cancellationToken)
        {
            var labelEntity = await context
                .Labels
                .FindAsync(request.TrackingNumber);

            return mapper.Map<LabelViewModel>(labelEntity);
        }
    }
}
