using PdfiumViewer.Demo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfiumViewer.Demo.DTO.Data
{
    class SuccessResponseRazdel : IResponse
    {
        public SuccessResponseRazdel(List<Razdeltable> razdeltables)
        {
            Razdeltables = razdeltables;
        }
        public string Code { get; set; } = "0";
        public string Description { get; set; } = "Success";
        public List<Razdeltable> Razdeltables { get; set; }
    }
}


