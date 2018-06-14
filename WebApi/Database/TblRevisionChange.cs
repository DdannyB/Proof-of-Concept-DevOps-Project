using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblRevisionChange
    {
        public long PkRevisionchangeid { get; set; }
        public long FkRevisionid { get; set; }
        public long? FkRevisionchangeuserid { get; set; }
        public string Changedfield { get; set; }
        public long Changetypeid { get; set; }
        public DateTime Changedate { get; set; }
        public string Oldvalue { get; set; }
        public string Newvalue { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Revisionchangetype { get; set; }
        public int Rightattributetype { get; set; }

        public TblRevision FkRevision { get; set; }
        public TblUser FkRevisionchangeuser { get; set; }
    }
}
