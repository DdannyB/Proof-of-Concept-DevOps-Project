using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblUserSecurity
    {
        public long PkUsersecurityid { get; set; }
        public long FkUserid { get; set; }
        public long? FkReviewgroupid { get; set; }
        public long FkProjectid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int? Hoursinweek { get; set; }

        public TblProject FkProject { get; set; }
        public TblReviewGroup FkReviewgroup { get; set; }
        public TblUser FkUser { get; set; }
    }
}
