using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeChecklist
    {
        public long PkScopechecklistid { get; set; }
        public long FkScopeid { get; set; }
        public long FkChecklistid { get; set; }
        public DateTime? Neededdate { get; set; }
        public DateTime? Receiveddate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkReceiveduserid { get; set; }
        public int? Checkliststate { get; set; }
        public long? FkNeededuserid { get; set; }

        public TblChecklist FkChecklist { get; set; }
        public TblUser FkNeededuser { get; set; }
        public TblUser FkReceiveduser { get; set; }
        public TblScope FkScope { get; set; }
    }
}
