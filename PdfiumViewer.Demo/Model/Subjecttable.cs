using System;
using System.Collections.Generic;


namespace PdfiumViewer.Demo
{
    public partial class Subjecttable
    {
        public Subjecttable()
        {
            Razdeltable = new HashSet<Razdeltable>();
        }

        public int Id { get; set; }
        public string SubjectName { get; set; }
        public int? IdKaf { get; set; }
        public string Author { get; set; }

        public virtual Kafedratable IdKafNavigation { get; set; }
        public virtual ICollection<Razdeltable> Razdeltable { get; set; }
    }
}
