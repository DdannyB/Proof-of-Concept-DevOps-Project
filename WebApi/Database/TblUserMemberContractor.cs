using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblUserMemberContractor
    {
        public long PkUsermembercontractorid { get; set; }
        public long FkUserid { get; set; }
        public long FkContractorid { get; set; }
        public long FkProjectid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool? Canbookprogress { get; set; }
        public bool? Canbookhours { get; set; }

        public TblContractor FkContractor { get; set; }
        public TblProject FkProject { get; set; }
        public TblUser FkUser { get; set; }
    }
}
