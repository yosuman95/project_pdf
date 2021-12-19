using PdfiumViewer.Demo.Contracts;
using PdfiumViewer.Demo.DTO.Data;
using Students.DTO.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PdfiumViewer.Demo.Controller
{
    class WorkRepository
    {
        private readonly booksdbstoreContext context;
        public WorkRepository()
        {
            context = new booksdbstoreContext();
        }
        public IResponse GetAllWorks()
        {
            List<WorkTable> workTables;
            try
            {
                workTables = context.WorkTable.ToList();
            }
            catch (Exception exp)
            {
                return new FailedResponse();
            }
            if (workTables.Count <= 0)
                return new NotFoundResponse();
            return new SuccessResponseWork(workTables);
        }

        public IResponse GetAllWorksById(int id)
        {
            List<string> workTables;
            try
            {
                workTables = new List<string>();
                var work = context.WorkTable.ToList();
                var typework = context.Sourcetable.Where(p => p.IdRazdel == id).ToList();                
                for (int i = 0; i < typework.Count; i++)
                {
                    if (work[i].Id == typework[i].IdWork)
                    {
                        workTables.Add(work[i].WorkName);                       
                    }
                }
                return new SuccessWorkResponseonlyName(workTables);
            }
            catch (Exception)
            {
                return new FailedResponse();
            }
        }
        public IResponse getidWorkbyName(String workName)
        {
            int id;
            try
            {
                id = context.WorkTable.Where(a => a.WorkName.Equals(workName.Trim()))
              .Select(a => a.Id).FirstOrDefault();
            }
            catch (Exception exp)
            {
                return new FailedResponse();
            }
            if (id <= 0)
                return new NotFoundResponse();
            return new SuccessResponseIntValue(id);
        }
        public static void AddWork(String workName)
        {
            using (booksdbstoreContext db = new booksdbstoreContext())
            {
                WorkTable workTable = new WorkTable { WorkName = workName };
                // Добавление
                db.WorkTable.Add(workTable);
                db.SaveChanges();
            }
        }
        public IResponse WorkAdd(WorkTable newworkTable)
        {
            try
            {
                WorkTable workTable = new WorkTable();
                workTable.WorkName = newworkTable.WorkName;                
                context.WorkTable.Add(workTable);
                context.SaveChanges();
                return new OkResponse();
            }
            catch (Exception e)
            {
                return new FailedResponse();
            }
        }
        public IResponse WorkUpdate(WorkTable newworkTable)
        {            
            try
            {
                WorkTable workTable = context.WorkTable.Where(p=>p.Id==newworkTable.Id).FirstOrDefault();
                workTable.WorkName = newworkTable.WorkName;
                context.WorkTable.Update(workTable);
                context.SaveChanges();
                return new OkResponse();
            }
            catch (Exception e)
            {
                return new FailedResponse();
            }
        }
        public IResponse WorkDelete(int id)
        {
            try
            {
                WorkTable workTable = context.WorkTable.Where(p => p.Id == id).FirstOrDefault();               
                context.WorkTable.Remove(workTable);
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
