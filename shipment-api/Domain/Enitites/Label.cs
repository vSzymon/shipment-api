using shipment_api.Domain.Enums;
using System.Collections.Generic;

namespace shipment_api.Domain.Enitites
{
    public record Label
    {
        public string LabelId { get; init; }
        public string PackageId { get; init; }
        public byte[] Image { get; init; }
        public ImageFileType ImageFileType { get; init; }
        public Package Package { get; init; }
    }
}
