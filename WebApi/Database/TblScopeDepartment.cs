using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeDepartment
    {
        public TblScopeDepartment()
        {
            TblScopeInput = new HashSet<TblScopeInput>();
        }

        public long PkScopedepartmentid { get; set; }
        public long FkScopeid { get; set; }
        public long FkDepartmentid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public DateTime? Finisheddate { get; set; }
        public string Finisheduser { get; set; }

        public TblDepartment FkDepartment { get; set; }
        public TblScope FkScope { get; set; }
        public ICollection<TblScopeInput> TblScopeInput { get; set; }
    }
}
