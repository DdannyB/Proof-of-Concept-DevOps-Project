using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWorkflowStateTransition
    {
        public TblWorkflowStateTransition()
        {
            TblChangeRequestWorkflowState = new HashSet<TblChangeRequestWorkflowState>();
            TblDrawingLayout = new HashSet<TblDrawingLayout>();
            TblWorkflowStateFkWorkflowstatetransitionreviewagreed = new HashSet<TblWorkflowState>();
            TblWorkflowStateFkWorkflowstatetransitionreviewnotagreed = new HashSet<TblWorkflowState>();
            TblWorkflowStateTransitionMail = new HashSet<TblWorkflowStateTransitionMail>();
            TblWorkflowStateTransitionOrganisationStructure = new HashSet<TblWorkflowStateTransitionOrganisationStructure>();
            TblWorkflowStateTransitionRole = new HashSet<TblWorkflowStateTransitionRole>();
        }

        public long PkWorkflowstatetransitionid { get; set; }
        public long FkWorkflowstateid { get; set; }
        public long FkNextworkflowstateid { get; set; }
        public string Statetransitionname { get; set; }
        public bool Isremarkrequired { get; set; }
        public bool Isrestrictedonorganisationstructure { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Isautomatictransition { get; set; }
        public bool Isrevertable { get; set; }
        public bool Isrevisiontransition { get; set; }
        public string Transitiondescription { get; set; }
        public bool Canbypasscompletioncheck { get; set; }
        public long? FkMailid { get; set; }
        public bool Signaturerequired { get; set; }
        public bool Freezeversion { get; set; }
        public bool Startreview { get; set; }
        public int? Mailrecipient { get; set; }
        public int? Transitionpermission { get; set; }
        public bool Usedbytemporarychangerequestcheck { get; set; }
        public bool Resetverifieddocumentscheck { get; set; }
        public bool Resetreviewandcomplexitydata { get; set; }
        public bool Excludefromfuturestatechecking { get; set; }
        public bool Ismessagerequired { get; set; }
        public bool Ismessagerequiredonrevert { get; set; }
        public bool Sendactionemails { get; set; }
        public bool Usedbypermanentchangerequestcheck { get; set; }

        public TblMail FkMail { get; set; }
        public TblWorkflowState FkNextworkflowstate { get; set; }
        public TblWorkflowState FkWorkflowstate { get; set; }
        public TblTimekeepingCutoff TblTimekeepingCutoff { get; set; }
        public ICollection<TblChangeRequestWorkflowState> TblChangeRequestWorkflowState { get; set; }
        public ICollection<TblDrawingLayout> TblDrawingLayout { get; set; }
        public ICollection<TblWorkflowState> TblWorkflowStateFkWorkflowstatetransitionreviewagreed { get; set; }
        public ICollection<TblWorkflowState> TblWorkflowStateFkWorkflowstatetransitionreviewnotagreed { get; set; }
        public ICollection<TblWorkflowStateTransitionMail> TblWorkflowStateTransitionMail { get; set; }
        public ICollection<TblWorkflowStateTransitionOrganisationStructure> TblWorkflowStateTransitionOrganisationStructure { get; set; }
        public ICollection<TblWorkflowStateTransitionRole> TblWorkflowStateTransitionRole { get; set; }
    }
}
