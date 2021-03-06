using shipment_api.Domain.Enums;

namespace shipment_api.Labels.Queries
{
    public record LabelViewModel
    {
        public byte[] Image { get; init; }
        public ImageFileType ImageFileType { get; init; }
    }
}
