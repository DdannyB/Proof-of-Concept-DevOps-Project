using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblToken
    {
        public long PkTokenid { get; set; }
        public long FkUserid { get; set; }
        public string Authenticationtoken { get; set; }
        public DateTime Issuedon { get; set; }
        public DateTime Expireson { get; set; }
        public Guid Sessionid { get; set; }
        public string Devicetoken { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblUser FkUser { get; set; }
    }
}
