using shipment_api.Domain.Enums;

namespace shipment_api.Domain.Enitites
{
    public record Label
    {
        public string Id { get; init; }
        public byte[] Image { get; init; }
        public ImageFileType ImageFileType { get; init; }
    }
}
