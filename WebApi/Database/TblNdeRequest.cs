using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblNdeRequest
    {
        public TblNdeRequest()
        {
            TblAttachment = new HashSet<TblAttachment>();
            TblNdeRequestDocumentLabel = new HashSet<TblNdeRequestDocumentLabel>();
        }

        public long PkNderequestid { get; set; }
        public long? FkWeldconnectionid { get; set; }
        public long? FkNdemainid { get; set; }
        public long? FkNdesubid { get; set; }
        public long? FkRequestbyuserid { get; set; }
        public long? FkContractorid { get; set; }
        public string Nderequestnr { get; set; }
        public string Location { get; set; }
        public DateTime? Plannedexedate { get; set; }
        public DateTime? Requestdate { get; set; }
        public DateTime? Acknowledgedate { get; set; }
        public long? FkAcknowledgebyuserid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Resultreportnr { get; set; }
        public DateTime? Readydate { get; set; }
        public long? FkReadybyuserid { get; set; }
        public long? FkNderesultid { get; set; }
        public string Resultmemo { get; set; }
        public string Plannedarealoc { get; set; }
        public int? Plannedprio { get; set; }
        public int? Plannedteam { get; set; }
        public string Resultfilmnr { get; set; }
        public long? FkBasematerialid { get; set; }
        public long? FkCancelbyuserid { get; set; }
        public decimal? Resultdefectlengthdin { get; set; }
        public decimal? Resultdefectlengthansi { get; set; }
        public long? FkProjectid { get; set; }
        public long? FkScopeid { get; set; }
        public long? FkWeldprocessid { get; set; }
        public long? FkNdecontractorid { get; set; }
        public long? FkWelderid { get; set; }
        public int Requesttypeenumvalue { get; set; }
        public DateTime? Canceldate { get; set; }
        public long? FkNdebatchid { get; set; }
        public long? FkNdedeadlineid { get; set; }
        public decimal? Inspectionvalue { get; set; }
        public long? FkInspectionvalueuomid { get; set; }
        public string Remark { get; set; }
        public int? Reexaminationnr { get; set; }
        public bool Isreexaminated { get; set; }
        public long? FkFillermaterialid { get; set; }

        public TblUser FkAcknowledgebyuser { get; set; }
        public TblBaseMaterial FkBasematerial { get; set; }
        public TblUser FkCancelbyuser { get; set; }
        public TblContractor FkContractor { get; set; }
        public TblFillerMaterial FkFillermaterial { get; set; }
        public TblUnitOfMeasurement FkInspectionvalueuom { get; set; }
        public TblNdeBatch FkNdebatch { get; set; }
        public TblContractor FkNdecontractor { get; set; }
        public TblNdeDeadline FkNdedeadline { get; set; }
        public TblNdeMain FkNdemain { get; set; }
        public TblNdeResults FkNderesult { get; set; }
        public TblNdeSub FkNdesub { get; set; }
        public TblProject FkProject { get; set; }
        public TblUser FkReadybyuser { get; set; }
        public TblUser FkRequestbyuser { get; set; }
        public TblScope FkScope { get; set; }
        public TblWeldConnection FkWeldconnection { get; set; }
        public TblWelder FkWelder { get; set; }
        public TblWeldProcess FkWeldprocess { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblNdeRequestDocumentLabel> TblNdeRequestDocumentLabel { get; set; }
    }
}
