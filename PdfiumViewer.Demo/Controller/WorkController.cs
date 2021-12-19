using PdfiumViewer.Demo.Contracts;
using PdfiumViewer.Demo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfiumViewer.Demo.Controller
{
    class WorkController
    {
        private readonly WorkService workService;
       public WorkController()
        {
            workService = new WorkService();
        }
        public IResponse GetAllWorks()
        {
            var razdel = workService.GetAllWorks();
            return razdel;
        }
        public IResponse GetAllWorksById(int id)
        {
            var razdel = workService.GetAllWorksById(id);
            return razdel;
        }
        public IResponse getidWorkbyName(String workName)
        {
            var razdel = workService.getidWorkbyName(workName);
            return razdel;
        }
        public IResponse WorkAdd(WorkTable newworkTable)
        {
            var razdel = workService.WorkAdd(newworkTable);
            return razdel;
        }
        public IResponse WorkUpdate(WorkTable newworkTable)
        {
            var razdel = workService.WorkUpdate(newworkTable);
            return razdel;
        }
        public IResponse WorkDelete(int id)
        {
            var razdel = workService.WorkDelete(id);
            return razdel;
        }
    }
}
