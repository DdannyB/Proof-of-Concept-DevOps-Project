using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindList
    {
        public TblBlindList()
        {
            TblAttachment = new HashSet<TblAttachment>();
            TblBlindListChecklist = new HashSet<TblBlindListChecklist>();
            TblBlindListDocumentLabel = new HashSet<TblBlindListDocumentLabel>();
            TblBlindListLog = new HashSet<TblBlindListLog>();
            TblBlindListRevision = new HashSet<TblBlindListRevision>();
            TblBlindListScope = new HashSet<TblBlindListScope>();
            TblBlindPoint = new HashSet<TblBlindPoint>();
            TblBlindProjectMainPhaseSubPhaseReleaseFinish = new HashSet<TblBlindProjectMainPhaseSubPhaseReleaseFinish>();
            TblBlindlistPidRevision = new HashSet<TblBlindlistPidRevision>();
            TblMyIsolationlist = new HashSet<TblMyIsolationlist>();
            TblPidRevisionIgnoreUpdate = new HashSet<TblPidRevisionIgnoreUpdate>();
        }

        public long PkBlindlistid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Memo { get; set; }
        public string Site { get; set; }
        public string Type { get; set; }
        public string Ordernumber { get; set; }
        public string Reference { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkLabelsid { get; set; }
        public long? FkContractorid { get; set; }
        public long? FkProjectid { get; set; }
        public long? FkBlindlisttypeid { get; set; }
        public long? FkPlantdataid { get; set; }
        public string Reviewedby { get; set; }
        public DateTime? Revieweddate { get; set; }
        public string Approvedby { get; set; }
        public DateTime? Approveddate { get; set; }
        public string Releasedby { get; set; }
        public DateTime? Releaseddate { get; set; }

        public TblBlindListType FkBlindlisttype { get; set; }
        public TblContractor FkContractor { get; set; }
        public TblLabels FkLabels { get; set; }
        public TblPlantData FkPlantdata { get; set; }
        public TblProject FkProject { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblBlindListChecklist> TblBlindListChecklist { get; set; }
        public ICollection<TblBlindListDocumentLabel> TblBlindListDocumentLabel { get; set; }
        public ICollection<TblBlindListLog> TblBlindListLog { get; set; }
        public ICollection<TblBlindListRevision> TblBlindListRevision { get; set; }
        public ICollection<TblBlindListScope> TblBlindListScope { get; set; }
        public ICollection<TblBlindPoint> TblBlindPoint { get; set; }
        public ICollection<TblBlindProjectMainPhaseSubPhaseReleaseFinish> TblBlindProjectMainPhaseSubPhaseReleaseFinish { get; set; }
        public ICollection<TblBlindlistPidRevision> TblBlindlistPidRevision { get; set; }
        public ICollection<TblMyIsolationlist> TblMyIsolationlist { get; set; }
        public ICollection<TblPidRevisionIgnoreUpdate> TblPidRevisionIgnoreUpdate { get; set; }
    }
}
