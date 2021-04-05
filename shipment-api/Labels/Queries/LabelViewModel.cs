using shipment_api.Common.Mappings;
using shipment_api.Domain.Enitites;
using shipment_api.Domain.Enums;

namespace shipment_api.Labels.Queries
{
    public record LabelViewModel : IMapFrom<Label>
    {
        public byte[] Image { get; init; }
        public ImageFileType ImageFileType { get; init; }
    }
}
