namespace SpareParts.Dto
{
    public class AttachmentDto : BaseDto
    {
        public string FileName { get; set; }

        public string Extension { get; set; }

        public string MimeType { get; set; }

        public byte[] Content { get; set; }

        public ProductDto Product { get; set; }
    }
}