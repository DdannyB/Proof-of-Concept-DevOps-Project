using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblChangeRequestAction
    {
        public long PkChangerequestactionid { get; set; }
        public long? FkActiontemplateid { get; set; }
        public long? FkActioncategoryid { get; set; }
        public long? FkWorkflowstateid { get; set; }
        public long FkChangerequestid { get; set; }
        public long FkInitiatinguserid { get; set; }
        public long FkResponsibleuserid { get; set; }
        public long? FkReadyuserid { get; set; }
        public string Actiondescription { get; set; }
        public string Actionmemo { get; set; }
        public DateTime? Actionduedate { get; set; }
        public DateTime? Actionreadydate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblActionCategory FkActioncategory { get; set; }
        public TblActionTemplate FkActiontemplate { get; set; }
        public TblChangeRequest FkChangerequest { get; set; }
        public TblUser FkInitiatinguser { get; set; }
        public TblUser FkReadyuser { get; set; }
        public TblUser FkResponsibleuser { get; set; }
        public TblWorkflowState FkWorkflowstate { get; set; }
    }
}
