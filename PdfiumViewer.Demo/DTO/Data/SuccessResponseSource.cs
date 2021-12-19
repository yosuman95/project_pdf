using PdfiumViewer.Demo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfiumViewer.Demo.DTO.Data
{
    class SuccessResponseSource:IResponse
    {
        public SuccessResponseSource(List<Sourcetable> sourcetables)
        {
            Sourcetables = sourcetables;
        }
        public string Code { get; set; } = "0";
        public string Description { get; set; } = "Success";
        public List<Sourcetable> Sourcetables { get; set; }
    }
}
