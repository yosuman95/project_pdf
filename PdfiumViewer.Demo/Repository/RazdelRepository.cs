using PdfiumViewer.Demo.Contracts;
using PdfiumViewer.Demo.DTO.Data;
using Students.DTO.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfiumViewer.Demo.Controller
{
    class RazdelRepository
    {
        private readonly booksdbstoreContext context;
        public RazdelRepository()
        {
            context = new booksdbstoreContext();
        }
        public IResponse GetAllRazdel()
        {
            List<Razdeltable> razdeltables;
            try
            {
                razdeltables = context.Razdeltable.ToList();

            }
            catch (Exception exp)
            {
                return new FailedResponse();
            }
            if (razdeltables.Count <= 0)
                return new NotFoundResponse();
            return new SuccessResponseRazdel(razdeltables);
        }

        public IResponse GetAllRazdelBySubject(int id)
        {
            List<Razdeltable> razdeltables;
            try
            {
                razdeltables = context.Razdeltable.Where(p => p.IdSubject == id).ToList();

            }
            catch (Exception exp)
            {
                return new FailedResponse();
            }
            if (razdeltables.Count <= 0)
                return new NotFoundResponse();
            return new SuccessResponseRazdel(razdeltables);
        }

        public IResponse getidRazdelByName(String razdelName)
        {
            int id;
            try
            {
                id = context.Razdeltable.Where(a => a.PartName.Equals(razdelName.Trim()))
             .Select(a => a.Id).FirstOrDefault();

            }
            catch (Exception exp)
            {
                return new FailedResponse();
            }
            if (id < 0)
                return new NotFoundResponse();
            return new SuccessResponseIntValue(id);
        }

        public IResponse AddRazdel(Razdeltable newrazdeltable)
        {
            try
            {
                Razdeltable razdeltable = new Razdeltable();
                razdeltable.PartName = newrazdeltable.PartName;
                razdeltable.IdSubject = newrazdeltable.IdSubject;

                // Добавление
                context.Razdeltable.Add(razdeltable);
                context.SaveChanges();
                return new OkResponse();
            }
            catch (Exception e)
            {
                return new FailedResponse();
            }
            return new NotFoundResponse();
        }

        public IResponse RazdelUpdate(Razdeltable newrazdeltable)
        {
            try
            {
                Razdeltable razdeltable = context.Razdeltable.Where(p => p.Id == newrazdeltable.Id).FirstOrDefault();
                razdeltable.PartName = newrazdeltable.PartName;
                razdeltable.IdSubject = newrazdeltable.IdSubject;
                MessageBox.Show(newrazdeltable.PartName + newrazdeltable.IdSubject.ToString());
                context.Razdeltable.Update(razdeltable);
                context.SaveChanges();
                return new OkResponse();
            }
            catch (Exception e)
            {
                return new FailedResponse();
            }
           
        }
        public IResponse RazdelDelete(int id)
        {
            try
            {
                Razdeltable razdeltable = context.Razdeltable.Where(p => p.Id == id).FirstOrDefault();
                if (razdeltable != null)
                {
                    context.Razdeltable.Remove(razdeltable);
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


