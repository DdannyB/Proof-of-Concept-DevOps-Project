using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPropackTemplate
    {
        public TblPropackTemplate()
        {
            TblPropackFilter = new HashSet<TblPropackFilter>();
        }

        public long PkPropacktemplateid { get; set; }
        public long FkProjectid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Templateusername { get; set; }
        public bool? Wpphasereadychecked { get; set; }
        public string Propacktemplatedescription { get; set; }
        public string Layout { get; set; }

        public TblProject FkProject { get; set; }
        public ICollection<TblPropackFilter> TblPropackFilter { get; set; }
    }
}
