using PdfiumViewer.Demo;
using PdfiumViewer.Demo.Contracts;
using System.Collections.Generic;
namespace Students.DTO.Data
{
    public class SuccessResponseKafedra : IResponse
    {
        public SuccessResponseKafedra(List<Kafedratable> kafedratables)
        {
            Kafedratables = kafedratables;
        }
        public string Code { get; set; } = "0";
        public string Description { get; set; } = "Success";
        public List<Kafedratable> Kafedratables { get; set; }
    }
}
