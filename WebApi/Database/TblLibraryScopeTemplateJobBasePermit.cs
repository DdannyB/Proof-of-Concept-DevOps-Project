using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryScopeTemplateJobBasePermit
    {
        public long PkLibraryscopetemplatejobbasepermitid { get; set; }
        public long FkLibraryscopetemplatejobid { get; set; }
        public long FkBasepermitid { get; set; }
        public string Basepermitjobname { get; set; }
        public bool Isparentjob { get; set; }
        public string Basepermitidentifier { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBasePermit FkBasepermit { get; set; }
        public TblLibraryScopeTemplateJob FkLibraryscopetemplatejob { get; set; }
    }
}
