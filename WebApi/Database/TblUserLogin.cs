using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblUserLogin
    {
        public long PkUserloginid { get; set; }
        public long? FkUserid { get; set; }
        public long FkApplicationid { get; set; }
        public long? FkProjectid { get; set; }
        public Guid Sessionguid { get; set; }
        public DateTime Logindate { get; set; }
        public DateTime? Logoutdate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public DateTime? Lastheartbeat { get; set; }
        public long? FkKickedbyuserid { get; set; }
        public string Kickedreason { get; set; }
        public bool Isreadonlylogin { get; set; }
        public string Applicationversion { get; set; }

        public TblApplication FkApplication { get; set; }
        public TblUser FkKickedbyuser { get; set; }
        public TblProject FkProject { get; set; }
        public TblUser FkUser { get; set; }
    }
}
