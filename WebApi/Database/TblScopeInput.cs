using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeInput
    {
        public long PkScopeinputid { get; set; }
        public long FkUserid { get; set; }
        public long FkScopedepartmentid { get; set; }
        public string Input { get; set; }
        public DateTime? Acceptancedate { get; set; }
        public string Acceptanceuser { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Acceptstate { get; set; }
        public string Remark { get; set; }

        public TblScopeDepartment FkScopedepartment { get; set; }
        public TblUser FkUser { get; set; }
    }
}
