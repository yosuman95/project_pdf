using System;
using System.Collections.Generic;
using System.Text;

namespace PdfiumViewer.Demo.Contracts
{
    public interface IResponse
    {
        string Code { get; set; }
        string Description { get; set; }
    }
}
