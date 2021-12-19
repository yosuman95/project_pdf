using PdfiumViewer.Demo.Contracts;
using PdfiumViewer.Demo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfiumViewer.Demo.Services
{
    class KafedraService
    {
        private readonly KafedraRepository repos;
        public KafedraService()
        {
            repos = new KafedraRepository();
        }

        public IResponse GetAllKafedra()
        {
            var kafedratables = repos.GetAllKafedra();
            return kafedratables;
        }

        public IResponse GetAllKafedraByID(int id)
        {
            var kafedratables = repos.GetAllKafedraByID(id);
            return kafedratables;
        }

        public IResponse KafedraAdd(Kafedratable kafedra)
        {
            var kafedratables = repos.KafedraAdd(kafedra);
            return kafedratables;
        }

        public IResponse KafedraUpdate(Kafedratable kafedra)
        {
            var kafedratables = repos.KafedraUpdate(kafedra);
            return kafedratables;
        }

        public IResponse KafedraDelete(int id)
        {
            var kafedratables = repos.KafedraDelete(id);
            return kafedratables;
        }

    }
}
