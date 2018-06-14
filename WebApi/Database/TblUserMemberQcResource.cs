using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblUserMemberQcResource
    {
        public long PkUsermemberqcresourceid { get; set; }
        public long FkUserid { get; set; }
        public long FkProjectid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkResourceid { get; set; }

        public TblProject FkProject { get; set; }
        public TblResource FkResource { get; set; }
        public TblUser FkUser { get; set; }
    }
}
