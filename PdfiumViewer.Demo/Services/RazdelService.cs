using PdfiumViewer.Demo.Contracts;
using PdfiumViewer.Demo.Controller;
using System;

namespace PdfiumViewer.Demo.Services
{
    class RazdelService
    {
        private readonly RazdelRepository repos;
        public RazdelService()
        {
            repos = new RazdelRepository();
        }
        public IResponse GetAllRazdel()
        {
            var razdel = repos.GetAllRazdel();
            return razdel;
        }
        public IResponse GetAllRazdelBySubject(int id)
        {
            var razdel = repos.GetAllRazdelBySubject(id);
            return razdel;
        }
        public IResponse getidRazdelByName(String razdelName)
        {
            var razdel = repos.getidRazdelByName(razdelName);
            return razdel;
        }
        public IResponse AddRazdel(Razdeltable newrazdeltable)
        {
            var razdel = repos.AddRazdel(newrazdeltable);
            return razdel;
        }
        public IResponse RazdelUpdate(Razdeltable newrazdeltable)
        {
            var razdel = repos.RazdelUpdate(newrazdeltable);
            return razdel;
        }
        public IResponse RazdelDelete(int id)
        {
            var razdel = repos.RazdelDelete(id);
            return razdel;
        }
    }
}
