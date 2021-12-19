using PdfiumViewer.Demo.Contracts;

namespace Students.DTO.Data
{
    class FailedResponse : IResponse
    {
        public string Code { get; set; } = "1";
        public string Description { get; set; } = "Database connection has been failed";
    }
}
