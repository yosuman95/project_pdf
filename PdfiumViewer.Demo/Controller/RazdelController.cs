using PdfiumViewer.Demo.Contracts;
using PdfiumViewer.Demo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfiumViewer.Demo.Controller
{
    class RazdelController
    {
        private readonly RazdelService razdelService;
        public RazdelController()
        {
            razdelService = new RazdelService();
        }
        public IResponse GetAllRazdel()
        {
            var razdel = razdelService.GetAllRazdel();
            return razdel;
        }
        public IResponse GetAllRazdelBySubject(int id)
        {
            var razdel = razdelService.GetAllRazdelBySubject(id);
            return razdel;
        }
        public IResponse getidRazdelByName(String razdelName)
        {
            var razdel = razdelService.getidRazdelByName(razdelName);
            return razdel;
        }
        public IResponse AddRazdel(Razdeltable newrazdeltable)
        {
            var razdel = razdelService.AddRazdel(newrazdeltable);
            return razdel;
        }
        public IResponse RazdelUpdate(Razdeltable newrazdeltable)
        {
            var razdel = razdelService.RazdelUpdate(newrazdeltable);
            return razdel;
        }
        public IResponse RazdelDelete(int id)
        {
            var razdel = razdelService.RazdelDelete(id);
            return razdel;
        }

    }
}
