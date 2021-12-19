using PdfiumViewer.Demo.Contracts;
using PdfiumViewer.Demo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfiumViewer.Demo.Controller
{
    class SourceController
    {
        private readonly SourceService sourceService;
        public SourceController()
        {
            sourceService = new SourceService();
        }
        public IResponse GetAllSources()
        {
            var razdel = sourceService.GetAllSources();
            return razdel;
        }
        public IResponse GetAllSourceByIdRazdel(int id)
        {
            var razdel = sourceService.GetAllSourceByIdRazdel(id);
            return razdel;
        }
        public IResponse SourceAdd(Sourcetable newsourcetable)
        {
            var razdel = sourceService.SourceAdd(newsourcetable);
            return razdel;
        }
        public IResponse SourceUpdate(Sourcetable newsourcetable)
        {
            var razdel = sourceService.SourceUpdate(newsourcetable);
            return razdel;
        }
        public IResponse SourceDelete(int id)
        {
            var razdel = sourceService.SourceDelete(id);
            return razdel;
        }
    }
}
