using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblProcessAreaRestrictedRightUserProcessArea
    {
        public long PkProcessarearestrictedrightuserprocessareaid { get; set; }
        public long FkProcessarearestrictedrightid { get; set; }
        public long FkUserid { get; set; }
        public long FkProcessareaid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProcessarea FkProcessarea { get; set; }
        public TblProcessAreaRestrictedRight FkProcessarearestrictedright { get; set; }
        public TblUser FkUser { get; set; }
    }
}
