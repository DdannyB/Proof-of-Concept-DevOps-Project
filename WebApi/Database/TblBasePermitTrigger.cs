using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBasePermitTrigger
    {
        public TblBasePermitTrigger()
        {
            TblBasePermitTriggerBasePermitItemPart = new HashSet<TblBasePermitTriggerBasePermitItemPart>();
            TblBasePermitTriggered = new HashSet<TblBasePermitTriggered>();
        }

        public long PkBasepermittriggerid { get; set; }
        public string Basepermittriggername { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkBasepermitid { get; set; }

        public TblBasePermit FkBasepermit { get; set; }
        public ICollection<TblBasePermitTriggerBasePermitItemPart> TblBasePermitTriggerBasePermitItemPart { get; set; }
        public ICollection<TblBasePermitTriggered> TblBasePermitTriggered { get; set; }
    }
}
