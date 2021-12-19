using PdfiumViewer.Demo.Contracts;
using PdfiumViewer.Demo.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfiumViewer.Demo.Services
{
    class SubjectService
    {
        private readonly SubjectRepository repos;
        public SubjectService()
        {
            repos = new SubjectRepository();
        }

        public IResponse GetAllSubjects()
        {
            var razdel = repos.GetAllSubjects();
            return razdel;

        }
        public IResponse GetAllSubjectsByIdKaf(int id)
        {
            var razdel = repos.GetAllSubjectsByIdKaf(id);
            return razdel;
        }
        public IResponse SubjectAdd(Subjecttable newsubjecttable)
        {
            var razdel = repos.SubjectAdd(newsubjecttable);
            return razdel;
        }
        public IResponse SubjectUpdate(Subjecttable newsubjecttable)
        {
            var razdel = repos.SubjectUpdate(newsubjecttable);
            return razdel;

        }
        public IResponse SubjectDelete(int id)
        {
            var razdel = repos.SubjectDelete(id);
            return razdel;
        }
    }
}
