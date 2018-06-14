using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblChangeRequest
    {
        public TblChangeRequest()
        {
            TblActiveChangeRequest = new HashSet<TblActiveChangeRequest>();
            TblChangeRequestAction = new HashSet<TblChangeRequestAction>();
            TblChangeRequestAdditionalPlantData = new HashSet<TblChangeRequestAdditionalPlantData>();
            TblChangeRequestChecklistItemUser = new HashSet<TblChangeRequestChecklistItemUser>();
            TblChangeRequestChecklistUser = new HashSet<TblChangeRequestChecklistUser>();
            TblChangeRequestDocumentItem = new HashSet<TblChangeRequestDocumentItem>();
            TblReview = new HashSet<TblReview>();
        }

        public long PkChangerequestid { get; set; }
        public long FkWorkflowid { get; set; }
        public long FkPlantdataid { get; set; }
        public long? FkCategoryid { get; set; }
        public long? FkCauseid { get; set; }
        public long? FkCostindicationrangeid { get; set; }
        public long? FkExecutionid { get; set; }
        public long? FkPriorityid { get; set; }
        public long FkRequestorid { get; set; }
        public long? FkResponsibleid { get; set; }
        public long FkAuditid { get; set; }
        public long? FkDocumentcontrollerid { get; set; }
        public string Changerequestnumber { get; set; }
        public string Changerequestdescription { get; set; }
        public string Problemdescription { get; set; }
        public string Solutiondescription { get; set; }
        public string Justification { get; set; }
        public string Uncertainties { get; set; }
        public string Payoutdescription { get; set; }
        public decimal? Payout { get; set; }
        public decimal? Cost { get; set; }
        public string Costdescription { get; set; }
        public DateTime Requestdate { get; set; }
        public int? Typeid { get; set; }
        public int Durationid { get; set; }
        public DateTime? Durationenddate { get; set; }
        public string Durationdescription { get; set; }
        public bool Equipmentinservice { get; set; }
        public bool Equipmentisolated { get; set; }
        public bool Equipmentbypassed { get; set; }
        public bool Equipmentbackupavailable { get; set; }
        public decimal? Durant { get; set; }
        public string Remarksrequestor { get; set; }
        public string Managementnotes { get; set; }
        public bool Nodocumentsneeded { get; set; }
        public bool Nodocumentsneededverify { get; set; }
        public string Statusmemo { get; set; }
        public string Ordernr { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? DkMatrixassessmentid { get; set; }

        public TblAudit FkAudit { get; set; }
        public TblCategory FkCategory { get; set; }
        public TblCause FkCause { get; set; }
        public TblCostIndicationRange FkCostindicationrange { get; set; }
        public TblUser FkDocumentcontroller { get; set; }
        public TblExecution FkExecution { get; set; }
        public TblPlantData FkPlantdata { get; set; }
        public TblPriority FkPriority { get; set; }
        public TblUser FkRequestor { get; set; }
        public TblUser FkResponsible { get; set; }
        public TblWorkflow FkWorkflow { get; set; }
        public ICollection<TblActiveChangeRequest> TblActiveChangeRequest { get; set; }
        public ICollection<TblChangeRequestAction> TblChangeRequestAction { get; set; }
        public ICollection<TblChangeRequestAdditionalPlantData> TblChangeRequestAdditionalPlantData { get; set; }
        public ICollection<TblChangeRequestChecklistItemUser> TblChangeRequestChecklistItemUser { get; set; }
        public ICollection<TblChangeRequestChecklistUser> TblChangeRequestChecklistUser { get; set; }
        public ICollection<TblChangeRequestDocumentItem> TblChangeRequestDocumentItem { get; set; }
        public ICollection<TblReview> TblReview { get; set; }
    }
}
