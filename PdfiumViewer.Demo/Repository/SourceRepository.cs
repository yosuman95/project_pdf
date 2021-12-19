using PdfiumViewer.Demo.Contracts;
using PdfiumViewer.Demo.DTO.Data;
using Students.DTO.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PdfiumViewer.Demo.Controller
{
    class SourceRepository
    {
        private readonly booksdbstoreContext context;
        public SourceRepository()
        {
            context = new booksdbstoreContext();
        }
        public IResponse GetAllSources()
        {
            List<Sourcetable> sourcetables;
            try
            {
                sourcetables = context.Sourcetable.ToList();
            }
            catch (Exception exp)
            {
                return new FailedResponse();
            }
            if (sourcetables.Count <= 0)
                return new NotFoundResponse();
            return new SuccessResponseSource(sourcetables);
        }
        public IResponse GetAllSourceByIdRazdel(int id)
        {
            List<Sourcetable> sourcetables;
            try
            {
                sourcetables = context.Sourcetable.Where(p=>p.IdRazdel==id).ToList();

            }
            catch (Exception exp)
            {
                return new FailedResponse();
            }
            if (sourcetables.Count <= 0)
                return new NotFoundResponse();
            return new SuccessResponseSource(sourcetables);
        }
        public IResponse SourceAdd(Sourcetable newsourcetable)
        {
            try
            {
                Sourcetable sourcetable = new Sourcetable();
                sourcetable.IdRazdel = newsourcetable.IdRazdel;
                sourcetable.IdWork = newsourcetable.IdWork;
                sourcetable.IdRazdelNavigation = newsourcetable.IdRazdelNavigation;                
                // Добавление
                context.Sourcetable.Add(sourcetable);
                context.SaveChanges();
                return new OkResponse();
            }
            catch (Exception e)
            {
                return new FailedResponse();
            }
            return new NotFoundResponse();
        }
        public IResponse SourceUpdate(Sourcetable newsourcetable)
        {
            try
            {
                Sourcetable sourcetable = context.Sourcetable.Where(p=>p.Id==newsourcetable.Id).FirstOrDefault();
                sourcetable.IdRazdel = newsourcetable.IdRazdel;
                sourcetable.IdWork = newsourcetable.IdWork;
                sourcetable.IdRazdelNavigation = newsourcetable.IdRazdelNavigation;
                // Добавление
                context.Sourcetable.Update(sourcetable);
                context.SaveChanges();
                return new OkResponse();
            }
            catch (Exception e)
            {
                return new FailedResponse();
            }
            return new NotFoundResponse();
        }
        public IResponse SourceDelete(int id)
        {
            try
            {
                Sourcetable sourcetable = context.Sourcetable.Where(p => p.Id ==id).FirstOrDefault();
               if (sourcetable != null)
                {
                    context.Sourcetable.Remove(sourcetable);
                    context.SaveChanges();
                    return new OkResponse();
                }                
            }
            catch (Exception e)
            {
                return new FailedResponse();
            }
            return new NotFoundResponse();
        }
    }
}
