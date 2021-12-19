using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PdfiumViewer.Demo
{
    public partial class Sourcetable
    {
        public int Id { get; set; }
        public int? IdRazdel { get; set; }
        public int? IdWork { get; set; }

        public virtual Razdeltable IdRazdelNavigation { get; set; }
        public virtual WorkTable IdWorkNavigation { get; set; }
    }
}
