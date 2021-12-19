using PdfiumViewer.Demo.Contracts;
using PdfiumViewer.Demo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfiumViewer.Demo.Controller
{
    class KafedraController
    {
        private readonly KafedraService kafedraService;
        public KafedraController()
        {
            kafedraService = new KafedraService();
        }

        public IResponse GetAllKafedra()
        {
            var kafedratables = kafedraService.GetAllKafedra();
            return kafedratables;
        }

        public IResponse GetAllKafedraByID(int id)
        {
            var kafedratables = kafedraService.GetAllKafedraByID(id);
            return kafedratables;
        }

        public IResponse KafedraAdd(Kafedratable kafedra)
        {
            var kafedratables = kafedraService.KafedraAdd(kafedra);
            return kafedratables;
        }

        public IResponse KafedraUpdate(Kafedratable kafedra)
        {
            var kafedratables = kafedraService.KafedraUpdate(kafedra);
            return kafedratables;
        }

        public IResponse KafedraDelete(int id)
        {
            var kafedratables = kafedraService.KafedraDelete(id);
            return kafedratables;
        }
    }
}
