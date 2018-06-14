using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindPoint
    {
        public TblBlindPoint()
        {
            TblAttachment = new HashSet<TblAttachment>();
            TblBlindPointActivity = new HashSet<TblBlindPointActivity>();
            TblBlindPointChecklist = new HashSet<TblBlindPointChecklist>();
            TblBlindPointDisciplineConfirmation = new HashSet<TblBlindPointDisciplineConfirmation>();
            TblBlindPointDocumentLabel = new HashSet<TblBlindPointDocumentLabel>();
            TblBlindPointHazard = new HashSet<TblBlindPointHazard>();
            TblBlindPointLog = new HashSet<TblBlindPointLog>();
        }

        public long PkBlindpointid { get; set; }
        public long FkBlindlistid { get; set; }
        public int Seqno { get; set; }
        public string Hazards { get; set; }
        public string Wpmemo { get; set; }
        public string Safetymemo { get; set; }
        public bool Active { get; set; }
        public string Reviewedby { get; set; }
        public DateTime? Revieweddate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkTemplateblindpointid { get; set; }
        public long? FkBoltingid { get; set; }
        public long? FkTestsystemid { get; set; }
        public string Approvedby { get; set; }
        public DateTime? Approveddate { get; set; }
        public string Refid { get; set; }
        public int? Refbox { get; set; }
        public string Blindpointdescription { get; set; }
        public long? FkBlindtypeid { get; set; }

        public TblBlindList FkBlindlist { get; set; }
        public TblBlindType FkBlindtype { get; set; }
        public TblBolting FkBolting { get; set; }
        public TblTemplateBlindPoint FkTemplateblindpoint { get; set; }
        public TblTestSystem FkTestsystem { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblBlindPointActivity> TblBlindPointActivity { get; set; }
        public ICollection<TblBlindPointChecklist> TblBlindPointChecklist { get; set; }
        public ICollection<TblBlindPointDisciplineConfirmation> TblBlindPointDisciplineConfirmation { get; set; }
        public ICollection<TblBlindPointDocumentLabel> TblBlindPointDocumentLabel { get; set; }
        public ICollection<TblBlindPointHazard> TblBlindPointHazard { get; set; }
        public ICollection<TblBlindPointLog> TblBlindPointLog { get; set; }
    }
}
