using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeJobDetailResourceTarget
    {
        public long PkScopejobdetailresourcetargetid { get; set; }
        public long FkScopejobdetailresourceid { get; set; }
        public long FkTargetid { get; set; }
        public DateTime? Resourcetargetactualstartdate { get; set; }
        public DateTime? Resourcetargetactualfinishdate { get; set; }
        public decimal? Resourcetargethours { get; set; }
        public int? Resourcetargetprogress { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkScopejobtargetid { get; set; }

        public TblScopeJobDetailResource FkScopejobdetailresource { get; set; }
        public TblScopeJobTarget FkScopejobtarget { get; set; }
        public TblTarget FkTarget { get; set; }
    }
}
