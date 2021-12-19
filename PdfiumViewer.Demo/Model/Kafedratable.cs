using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PdfiumViewer.Demo
{
    public partial class Kafedratable
    {
        public Kafedratable()
        {
            Subjecttable = new HashSet<Subjecttable>();
        }

        public int Id { get; set; }
        public string KafName { get; set; }

        public virtual ICollection<Subjecttable> Subjecttable { get; set; }
    }
}
