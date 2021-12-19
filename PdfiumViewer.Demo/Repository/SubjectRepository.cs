using PdfiumViewer.Demo.Contracts;
using PdfiumViewer.Demo.DTO.Data;
using Students.DTO.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PdfiumViewer.Demo.Controller
{
    class SubjectRepository
    {
        private readonly booksdbstoreContext context;
        public SubjectRepository()
        {
            context = new booksdbstoreContext();
        }
        public IResponse GetAllSubjects()
        {
            List<Subjecttable> subjecttables;
            try
            {
                subjecttables = context.Subjecttable.ToList();
            }
            catch (Exception exp)
            {
                return new FailedResponse();
            }
            if (subjecttables.Count <= 0)
                return new NotFoundResponse();
            return new SuccessResponseSubject(subjecttables);
        }
        public IResponse GetAllSubjectsByIdKaf(int id)
        {
            List<Subjecttable> subjecttables;
            try
            {
                subjecttables = context.Subjecttable.Where(p => p.IdKaf == id).ToList();
            }
            catch (Exception exp)
            {
                return new FailedResponse();
            }
            if (subjecttables.Count <= 0)
                return new NotFoundResponse();
            return new SuccessResponseSubject(subjecttables);
        }
        public IResponse SubjectAdd(Subjecttable newsubjecttable)
        {
            try
            {
                Subjecttable subjecttables = new Subjecttable();
                subjecttables.Author = newsubjecttable.Author;
                subjecttables.IdKaf = newsubjecttable.IdKaf;                           
                subjecttables.SubjectName = newsubjecttable.SubjectName;
                context.Subjecttable.Add(subjecttables);
                context.SaveChanges();
                return new OkResponse();
            }
            catch (Exception e)
            {
                return new FailedResponse();
            }
            return new NotFoundResponse();
        }
        public IResponse SubjectUpdate(Subjecttable newsubjecttable)
        {
            try
            {
                Subjecttable subjecttables = context.Subjecttable.Where(p => p.Id == newsubjecttable.Id).FirstOrDefault();
                subjecttables.Author = newsubjecttable.Author;
                subjecttables.IdKaf = newsubjecttable.IdKaf;               
                subjecttables.SubjectName = newsubjecttable.SubjectName;
                context.Subjecttable.Add(subjecttables);
                context.SaveChanges();
                return new OkResponse();
            }
            catch (Exception e)
            {
                return new FailedResponse();
            }
        }
        public IResponse SubjectDelete(int id)
        {
            try
            {
                Subjecttable subjecttables = context.Subjecttable.Where(p => p.Id == id).FirstOrDefault();                
                context.Subjecttable.Remove(subjecttables);
                context.SaveChanges();
                return new OkResponse();
            }
            catch (Exception e)
            {
                return new FailedResponse();
            }
        }
    }
}
