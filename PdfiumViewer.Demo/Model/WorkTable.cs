using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PdfiumViewer.Demo
{
    public partial class WorkTable
    {
        public WorkTable()
        {
            Sourcetable = new HashSet<Sourcetable>();
        }

        public int Id { get; set; }
        public string WorkName { get; set; }

        public virtual ICollection<Sourcetable> Sourcetable { get; set; }
    }
}
