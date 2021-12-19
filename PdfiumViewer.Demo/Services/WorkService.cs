using PdfiumViewer.Demo.Contracts;
using PdfiumViewer.Demo.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfiumViewer.Demo.Services
{
    class WorkService
    {
        private readonly WorkRepository repos;
        public WorkService()
        {
            repos = new WorkRepository();
        }
        public IResponse GetAllWorks()
        {
            var razdel = repos.GetAllWorks();
            return razdel;
        }
        public IResponse GetAllWorksById(int id)
        {
            var razdel = repos.GetAllWorksById(id);
            return razdel;
        }
        public IResponse getidWorkbyName(String workName)
        {
            var razdel = repos.getidWorkbyName(workName);
            return razdel;
        } 
        public IResponse WorkAdd(WorkTable newworkTable)
        {
            var razdel = repos.WorkAdd(newworkTable);
            return razdel;
        }
        public IResponse WorkUpdate(WorkTable newworkTable)
        {
            var razdel = repos.WorkUpdate(newworkTable);
            return razdel;
        }
        public IResponse WorkDelete(int id)
        {
            var razdel = repos.WorkDelete(id);
            return razdel;
        }
    }
}
