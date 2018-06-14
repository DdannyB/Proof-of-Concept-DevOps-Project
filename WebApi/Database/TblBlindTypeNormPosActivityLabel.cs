using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindTypeNormPosActivityLabel
    {
        public long PkBlindtypenormposactivitylabelid { get; set; }
        public long FkBlindtypenormposactivityid { get; set; }
        public long FkBasereportid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBaseReport FkBasereport { get; set; }
        public TblBlindTypeNormPosActivity FkBlindtypenormposactivity { get; set; }
    }
}
