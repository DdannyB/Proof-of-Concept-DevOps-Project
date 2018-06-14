using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPasswordHistory
    {
        public long PkPasswordhistoryid { get; set; }
        public long FkUserid { get; set; }
        public string Password { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblUser FkUser { get; set; }
    }
}
