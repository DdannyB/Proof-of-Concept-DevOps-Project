using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeJobDetailTarget
    {
        public long PkScopejobdetailtargetid { get; set; }
        public long FkScopejobdetailid { get; set; }
        public long FkTargetid { get; set; }
        public string Scopejobdetailname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblScopeJobDetail FkScopejobdetail { get; set; }
        public TblTarget FkTarget { get; set; }
    }
}
