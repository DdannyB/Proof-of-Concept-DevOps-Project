using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLisl
    {
        public TblLisl()
        {
            TblAttachment = new HashSet<TblAttachment>();
            TblLislDocumentLabel = new HashSet<TblLislDocumentLabel>();
            TblLislLislRemark = new HashSet<TblLislLislRemark>();
            TblLislNdeInspectionPlan = new HashSet<TblLislNdeInspectionPlan>();
            TblLislProgress = new HashSet<TblLislProgress>();
            TblWeldConnection = new HashSet<TblWeldConnection>();
        }

        public long PkLislid { get; set; }
        public string Lislnr { get; set; }
        public long? FkRequestorid { get; set; }
        public long FkScopeid { get; set; }
        public long? FkMaincontractorid { get; set; }
        public string Isometricnr { get; set; }
        public string Isometricrevnr { get; set; }
        public string Isometricsheetnr { get; set; }
        public string Drawingnr { get; set; }
        public string Drawingrevnr { get; set; }
        public long? FkMaterialpipespecid { get; set; }
        public string Eqptagnr { get; set; }
        public string Regnr { get; set; }
        public string Wregnr { get; set; }
        public bool? Pwht { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkScopechangeuserid { get; set; }
        public long? FkCategoryid { get; set; }
        public long? FkWeldprocedureid { get; set; }
        public long? FkProjectid { get; set; }
        public long? FkTestsystemid { get; set; }
        public long? FkPipelineid { get; set; }
        public DateTime? Testsystemfreezedate { get; set; }
        public string Testsystemfreezeuser { get; set; }
        public string Designcode { get; set; }
        public DateTime? Isdeleted { get; set; }
        public string Deleteuser { get; set; }
        public long? FkNobocontractorid { get; set; }

        public TblCategory FkCategory { get; set; }
        public TblContractor FkMaincontractor { get; set; }
        public TblMaterialPipeSpec FkMaterialpipespec { get; set; }
        public TblContractor FkNobocontractor { get; set; }
        public TblPipeline FkPipeline { get; set; }
        public TblProject FkProject { get; set; }
        public TblUser FkRequestor { get; set; }
        public TblScope FkScope { get; set; }
        public TblUser FkScopechangeuser { get; set; }
        public TblTestSystem FkTestsystem { get; set; }
        public TblWeldProcedure FkWeldprocedure { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblLislDocumentLabel> TblLislDocumentLabel { get; set; }
        public ICollection<TblLislLislRemark> TblLislLislRemark { get; set; }
        public ICollection<TblLislNdeInspectionPlan> TblLislNdeInspectionPlan { get; set; }
        public ICollection<TblLislProgress> TblLislProgress { get; set; }
        public ICollection<TblWeldConnection> TblWeldConnection { get; set; }
    }
}
