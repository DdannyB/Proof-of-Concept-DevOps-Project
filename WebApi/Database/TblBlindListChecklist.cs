using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindListChecklist
    {
        public long PkBlindlistchecklistid { get; set; }
        public long FkBlindlistid { get; set; }
        public long FkChecklistid { get; set; }
        public long? FkUserid { get; set; }
        public DateTime? Neededdate { get; set; }
        public DateTime? Receiveddate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBlindList FkBlindlist { get; set; }
        public TblChecklist FkChecklist { get; set; }
        public TblUser FkUser { get; set; }
    }
}
