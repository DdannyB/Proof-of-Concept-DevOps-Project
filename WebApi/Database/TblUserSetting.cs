using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblUserSetting
    {
        public long PkUsersetting { get; set; }
        public long FkUserid { get; set; }
        public long? FkProjectid { get; set; }
        public int? Application { get; set; }
        public string Keyfield { get; set; }
        public string Value { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkSubprojectid { get; set; }

        public TblProject FkProject { get; set; }
        public TblSubProject FkSubproject { get; set; }
        public TblUser FkUser { get; set; }
    }
}
