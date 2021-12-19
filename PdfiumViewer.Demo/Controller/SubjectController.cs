using PdfiumViewer.Demo.Contracts;
using PdfiumViewer.Demo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfiumViewer.Demo.Controller
{
    class SubjectController
    {
        private readonly SubjectService subjectService;        
        public SubjectController()
        {
            subjectService = new SubjectService();
        }
        public IResponse GetAllSubjects()
        {
            var razdel = subjectService.GetAllSubjects();
            return razdel;
        }
        public IResponse GetAllSubjectsByIdKaf(int id)
        {
            var razdel = subjectService.GetAllSubjectsByIdKaf(id);
            return razdel;
        }
        public IResponse SubjectAdd(Subjecttable newsubjecttable)
        {
            var razdel = subjectService.SubjectAdd(newsubjecttable);
            return razdel;
        }
        public IResponse SubjectUpdate(Subjecttable newsubjecttable)
        {
            var razdel = subjectService.SubjectUpdate(newsubjecttable);
            return razdel;
        }
        public IResponse SubjectDelete(int id)
        {
            var razdel = subjectService.SubjectDelete(id);
            return razdel;
        }
    }
}
