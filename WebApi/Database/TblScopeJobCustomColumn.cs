using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeJobCustomColumn
    {
        public long PkScopejobcustomcolumnid { get; set; }
        public long FkScopejobid { get; set; }
        public long FkCustomcolumnid { get; set; }
        public string Scopejobcustomcolumnvalue { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblCustomColumn FkCustomcolumn { get; set; }
        public TblScopeJob FkScopejob { get; set; }
    }
}
