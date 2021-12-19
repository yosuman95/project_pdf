using PdfiumViewer.Demo.Contracts;

namespace Students.DTO.Data
{
    class NotFoundResponse : IResponse
    {
        public string Code { get; set; } = "1";
        public string Description { get; set; } = " Not Found Records";
    }
}
