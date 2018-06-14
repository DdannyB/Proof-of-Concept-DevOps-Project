using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBasePermitAuthorization
    {
        public TblBasePermitAuthorization()
        {
            TblBasePermitItemAuthorization = new HashSet<TblBasePermitItemAuthorization>();
        }

        public long PkBasepermitauthorizationid { get; set; }
        public long FkWorkflowstateid { get; set; }
        public long FkPermitfunctiongroupid { get; set; }
        public long FkBasepermitid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBasePermit FkBasepermit { get; set; }
        public TblPermitFunctionGroup FkPermitfunctiongroup { get; set; }
        public TblWorkflowState FkWorkflowstate { get; set; }
        public ICollection<TblBasePermitItemAuthorization> TblBasePermitItemAuthorization { get; set; }
    }
}
