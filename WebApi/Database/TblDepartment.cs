using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDepartment
    {
        public TblDepartment()
        {
            TblDepartmentSection = new HashSet<TblDepartmentSection>();
            TblScopeDepartment = new HashSet<TblScopeDepartment>();
            TblUserDepartment = new HashSet<TblUserDepartment>();
        }

        public long PkDepartmentid { get; set; }
        public string Departmentname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Ischangeitdepartment { get; set; }
        public bool Isscopeitdepartment { get; set; }

        public ICollection<TblDepartmentSection> TblDepartmentSection { get; set; }
        public ICollection<TblScopeDepartment> TblScopeDepartment { get; set; }
        public ICollection<TblUserDepartment> TblUserDepartment { get; set; }
    }
}
