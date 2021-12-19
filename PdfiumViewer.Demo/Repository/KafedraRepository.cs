using PdfiumViewer.Demo.Contracts;
using PdfiumViewer.Demo.DTO.Data;
using Students.DTO.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PdfiumViewer.Demo.Repository
{
    class KafedraRepository
    {
        private readonly booksdbstoreContext context;
        public KafedraRepository()
        {
            context = new booksdbstoreContext();
        }
        public IResponse GetAllKafedra()
        {
            IResponse response;
            List<Kafedratable> kafedratables;
            try
            {
                kafedratables = context.Kafedratable.ToList();

            }
            catch (Exception exp)
            {
                return new FailedResponse();
            }
            if (kafedratables.Count <= 0)
                return new NotFoundResponse();
            return new SuccessResponseKafedra(kafedratables);
        }

        public IResponse GetAllKafedraByID(int id)
        {
            IResponse response;
            List<Kafedratable> kafedratables;
            try
            {
                kafedratables = context.Kafedratable.Where(p => p.Id.Equals(id)).ToList();

            }
            catch (Exception exp)
            {
                return new FailedResponse();
            }
            if (kafedratables.Count <= 0)
                return new NotFoundResponse();
            return new SuccessResponseKafedra(kafedratables);
        }

        public IResponse KafedraAdd(Kafedratable kafedra)
        {
            try
            {
                Kafedratable kafedratable = new Kafedratable();
                kafedratable.KafName = kafedra.KafName;
                context.Kafedratable.Add(kafedra);
                context.SaveChanges();
                return new OkResponse();
            }
            catch (Exception e)
            {
                return new FailedResponse();
            }
            return new NotFoundResponse();
        }

        public IResponse KafedraUpdate(Kafedratable kafedra)
        {
            try
            {
                Kafedratable kafedratable = context.Kafedratable.Where(p => p.Id == kafedra.Id).FirstOrDefault();
                kafedratable.KafName = kafedra.KafName;
                context.Kafedratable.Add(kafedra);
                context.SaveChanges();
                return new OkResponse();
            }
            catch (Exception e)
            {
                return new FailedResponse();
            }
        }

        public IResponse KafedraDelete(int id)
        {
            try
            {
                Kafedratable kafedratable = context.Kafedratable.Where(p => p.Id == id).FirstOrDefault();
                if (kafedratable != null)
                {
                    context.Kafedratable.Remove(kafedratable);
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
