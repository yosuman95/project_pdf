using PdfiumViewer.Demo.Contracts;
using PdfiumViewer.Demo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfiumViewer.Demo.Services
{
    class SourceService
    {
        private readonly SourceService repos;
        public SourceService()
        {
            repos = new SourceService();
        }
        public IResponse GetAllSources()
        {
            var razdel = repos.GetAllSources();
            return razdel;
        }
        public IResponse GetAllSourceByIdRazdel(int id)
        {
            var razdel = repos.GetAllSourceByIdRazdel(id);
            return razdel;
        }
        public IResponse SourceAdd(Sourcetable newsourcetable)
        {
            var razdel = repos.SourceAdd(newsourcetable);
            return razdel;
        }
        public IResponse SourceUpdate(Sourcetable newsourcetable)
        {
            var razdel = repos.SourceUpdate(newsourcetable);
            return razdel;
        }
        public IResponse SourceDelete(int id)
        {
            var razdel = repos.SourceDelete(id);
            return razdel;
        }
    }
}
