using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblChangeRequestChecklistItemUser
    {
        public long PkChangerequestchecklistitemuserid { get; set; }
        public long FkChangerequestid { get; set; }
        public long FkChecklistitemid { get; set; }
        public long FkUserid { get; set; }
        public bool Changerequestchecklistitemuseragreed { get; set; }
        public bool Changerequestchecklistitemusernotagreed { get; set; }
        public bool Changerequestchecklistitemuseragreedremark { get; set; }
        public bool Changerequestchecklistitemusernotapplicable { get; set; }
        public string Changerequestchecklistitemuserremark { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkWorkflowstateid { get; set; }

        public TblChangeRequest FkChangerequest { get; set; }
        public TblChecklistItem FkChecklistitem { get; set; }
        public TblUser FkUser { get; set; }
        public TblWorkflowState FkWorkflowstate { get; set; }
    }
}
