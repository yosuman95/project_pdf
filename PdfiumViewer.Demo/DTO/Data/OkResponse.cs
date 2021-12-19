using PdfiumViewer.Demo.Contracts;

namespace PdfiumViewer.Demo.DTO.Data
{
    class OkResponse : IResponse
    {
        public string Code { get; set; } = "0";
        public string Description { get; set; } = "Success";
    }
}
