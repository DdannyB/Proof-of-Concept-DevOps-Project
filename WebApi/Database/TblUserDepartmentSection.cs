using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblUserDepartmentSection
    {
        public long PkUserdepartmentsectionid { get; set; }
        public long FkUserid { get; set; }
        public long FkDepartmentsectionid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDepartmentSection FkDepartmentsection { get; set; }
        public TblUser FkUser { get; set; }
    }
}
