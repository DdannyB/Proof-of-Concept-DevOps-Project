using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPropack
    {
        public TblPropack()
        {
            TblPropackExport = new HashSet<TblPropackExport>();
            TblPropackFilter = new HashSet<TblPropackFilter>();
        }

        public long PkPropackid { get; set; }
        public long? DkPropacktemplateid { get; set; }
        public long FkProjectid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Propacktitle { get; set; }
        public Guid Propackidentification { get; set; }
        public int Propacknr { get; set; }
        public string Propackmemo { get; set; }
        public string Propacktemplatename { get; set; }
        public string Propackusername { get; set; }
        public bool Ispropacktemplatemodified { get; set; }
        public string Layout { get; set; }

        public TblProject FkProject { get; set; }
        public ICollection<TblPropackExport> TblPropackExport { get; set; }
        public ICollection<TblPropackFilter> TblPropackFilter { get; set; }
    }
}
