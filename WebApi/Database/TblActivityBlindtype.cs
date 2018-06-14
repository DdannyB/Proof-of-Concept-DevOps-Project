using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblActivityBlindtype
    {
        public long PkActivityblindtype { get; set; }
        public long FkActivityid { get; set; }
        public long FkBlindtypeid { get; set; }
        public bool Isdefault { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblActivity FkActivity { get; set; }
        public TblBlindType FkBlindtype { get; set; }
    }
}
