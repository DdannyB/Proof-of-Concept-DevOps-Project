using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDepartmentSection
    {
        public TblDepartmentSection()
        {
            TblUserDepartmentSection = new HashSet<TblUserDepartmentSection>();
        }

        public long PkDepartmentsectionid { get; set; }
        public long FkDepartmentid { get; set; }
        public string Sectionname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDepartment FkDepartment { get; set; }
        public ICollection<TblUserDepartmentSection> TblUserDepartmentSection { get; set; }
    }
}
