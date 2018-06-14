using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblChangeRequestChecklistUser
    {
        public long PkChangerequestchecklistuserid { get; set; }
        public long FkChangerequestid { get; set; }
        public long FkChecklistid { get; set; }
        public long FkUserid { get; set; }
        public bool Changerequestchecklistuseragreed { get; set; }
        public bool Changerequestchecklistusernotagreed { get; set; }
        public bool Changerequestchecklistuseragreedremark { get; set; }
        public bool Changerequestchecklistusernotapplicable { get; set; }
        public string Changerequestchecklistuserremark { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkWorkflowstateid { get; set; }

        public TblChangeRequest FkChangerequest { get; set; }
        public TblChecklist FkChecklist { get; set; }
        public TblUser FkUser { get; set; }
        public TblWorkflowState FkWorkflowstate { get; set; }
    }
}
