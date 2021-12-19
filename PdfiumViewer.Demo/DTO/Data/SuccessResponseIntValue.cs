using PdfiumViewer.Demo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfiumViewer.Demo.DTO.Data
{
    class SuccessResponseIntValue : IResponse
    {
      public SuccessResponseIntValue(int value)
        {
            Value = value;
        }
        public string Code { get; set; } = "0";
        public string Description { get; set; } = "Success";
        public int Value { get; set; }
    }
}
