using PdfiumViewer.Demo.Contracts;
using System.Collections.Generic;

namespace PdfiumViewer.Demo.DTO.Data
{
    class SuccessResponseSubject : IResponse
    {       
            public SuccessResponseSubject(List<Subjecttable> subjecttables)
            {
                Subjecttables = subjecttables;
            }
            public string Code { get; set; } = "0";
            public string Description { get; set; } = "Success";
            public List<Subjecttable> Subjecttables { get; set; }
        }
    }

