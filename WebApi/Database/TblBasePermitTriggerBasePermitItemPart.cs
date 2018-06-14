using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBasePermitTriggerBasePermitItemPart
    {
        public long PkBasepermittriggerbasepermititempartid { get; set; }
        public long FkBasepermittriggerid { get; set; }
        public long FkBasepermititempartid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBasePermitItemPart FkBasepermititempart { get; set; }
        public TblBasePermitTrigger FkBasepermittrigger { get; set; }
    }
}
