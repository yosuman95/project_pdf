using System;
using System.Collections.Generic;

namespace PdfiumViewer.Demo
{
    public partial class Razdeltable
    {
        public Razdeltable()
        {
            Sourcetable = new HashSet<Sourcetable>();
        }

        public int Id { get; set; }
        public string PartName { get; set; }
        public int? IdSubject { get; set; }

        public virtual Subjecttable IdSubjectNavigation { get; set; }
        public virtual ICollection<Sourcetable> Sourcetable { get; set; }
    }
}
