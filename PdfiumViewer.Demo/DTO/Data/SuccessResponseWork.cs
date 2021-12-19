using PdfiumViewer.Demo.Contracts;
using System.Collections.Generic;

namespace PdfiumViewer.Demo.DTO.Data
{
    class SuccessResponseWork : IResponse
    {
        public SuccessResponseWork(List<WorkTable> workTables)
        {
            WorkTables = workTables;
        }
        public string Code { get; set; } = "0";
        public string Description { get; set; } = "Success";
        public List<WorkTable> WorkTables { get; set; }
    }
}
