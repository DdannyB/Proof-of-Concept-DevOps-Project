using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindPointActivityChecklist
    {
        public long PkBlindpointactivitychecklistid { get; set; }
        public long FkBlindpointactivityid { get; set; }
        public long FkChecklistid { get; set; }
        public long? FkUserid { get; set; }
        public int Activityqctype { get; set; }
        public DateTime? Neededdate { get; set; }
        public DateTime? Receiveddate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBlindPointActivity FkBlindpointactivity { get; set; }
        public TblChecklist FkChecklist { get; set; }
        public TblUser FkUser { get; set; }
    }
}
