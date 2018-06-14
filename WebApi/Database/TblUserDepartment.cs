using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblUserDepartment
    {
        public long PkUserdepartmentid { get; set; }
        public long FkUserid { get; set; }
        public long FkDepartmentid { get; set; }
        public long FkProjectid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDepartment FkDepartment { get; set; }
        public TblProject FkProject { get; set; }
        public TblUser FkUser { get; set; }
    }
}
