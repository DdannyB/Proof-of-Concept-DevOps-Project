using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPermitMessage
    {
        public long PkPermitmessageid { get; set; }
        public long FkPermitid { get; set; }
        public int Permitmessagetype { get; set; }
        public string Permitmessageheader { get; set; }
        public string Permitmessage { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkUserid { get; set; }

        public TblPermit FkPermit { get; set; }
        public TblUser FkUser { get; set; }
    }
}
