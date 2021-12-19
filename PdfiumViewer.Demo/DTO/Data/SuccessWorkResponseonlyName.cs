using PdfiumViewer.Demo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfiumViewer.Demo.DTO.Data
{
    class SuccessWorkResponseonlyName:IResponse
    {
        public SuccessWorkResponseonlyName(List<string> workTables)
        {
            WorkTables = workTables;
        }
        public string Code { get; set; } = "0";
        public string Description { get; set; } = "Success";
        public List<string> WorkTables { get; set; }
    }
}
