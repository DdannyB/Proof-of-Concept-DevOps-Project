using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWorkflowState
    {
        public TblWorkflowState()
        {
            TblActionTemplate = new HashSet<TblActionTemplate>();
            TblBasePermitAuthorization = new HashSet<TblBasePermitAuthorization>();
            TblChangeRequestAction = new HashSet<TblChangeRequestAction>();
            TblChangeRequestChecklistItemUser = new HashSet<TblChangeRequestChecklistItemUser>();
            TblChangeRequestChecklistUser = new HashSet<TblChangeRequestChecklistUser>();
            TblChangeRequestWorkflowState = new HashSet<TblChangeRequestWorkflowState>();
            TblDrawingLayout = new HashSet<TblDrawingLayout>();
            TblKpisettingFkEndworkflowstate = new HashSet<TblKpisetting>();
            TblKpisettingFkStartworkflowstate = new HashSet<TblKpisetting>();
            TblPermit = new HashSet<TblPermit>();
            TblPermitWorkflowState = new HashSet<TblPermitWorkflowState>();
            TblReview = new HashSet<TblReview>();
            TblTimekeepingEntry = new HashSet<TblTimekeepingEntry>();
            TblTimekeepingSheet = new HashSet<TblTimekeepingSheet>();
            TblWorkflowStateRightRestriction = new HashSet<TblWorkflowStateRightRestriction>();
            TblWorkflowStateTransitionFkNextworkflowstate = new HashSet<TblWorkflowStateTransition>();
            TblWorkflowStateTransitionFkWorkflowstate = new HashSet<TblWorkflowStateTransition>();
        }

        public long PkWorkflowstateid { get; set; }
        public long FkWorkflowid { get; set; }
        public string Statename { get; set; }
        public bool Isinitialstate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Statecolor { get; set; }
        public int Workflowstatetype { get; set; }
        public bool Iseditable { get; set; }
        public int? Sortorder { get; set; }
        public string Statedescription { get; set; }
        public int? Statecompletionchecks { get; set; }
        public bool Isarchivestate { get; set; }
        public long? FkWorkflowstatetransitionreviewagreedid { get; set; }
        public long? FkWorkflowstatetransitionreviewnotagreedid { get; set; }

        public TblWorkflow FkWorkflow { get; set; }
        public TblWorkflowStateTransition FkWorkflowstatetransitionreviewagreed { get; set; }
        public TblWorkflowStateTransition FkWorkflowstatetransitionreviewnotagreed { get; set; }
        public ICollection<TblActionTemplate> TblActionTemplate { get; set; }
        public ICollection<TblBasePermitAuthorization> TblBasePermitAuthorization { get; set; }
        public ICollection<TblChangeRequestAction> TblChangeRequestAction { get; set; }
        public ICollection<TblChangeRequestChecklistItemUser> TblChangeRequestChecklistItemUser { get; set; }
        public ICollection<TblChangeRequestChecklistUser> TblChangeRequestChecklistUser { get; set; }
        public ICollection<TblChangeRequestWorkflowState> TblChangeRequestWorkflowState { get; set; }
        public ICollection<TblDrawingLayout> TblDrawingLayout { get; set; }
        public ICollection<TblKpisetting> TblKpisettingFkEndworkflowstate { get; set; }
        public ICollection<TblKpisetting> TblKpisettingFkStartworkflowstate { get; set; }
        public ICollection<TblPermit> TblPermit { get; set; }
        public ICollection<TblPermitWorkflowState> TblPermitWorkflowState { get; set; }
        public ICollection<TblReview> TblReview { get; set; }
        public ICollection<TblTimekeepingEntry> TblTimekeepingEntry { get; set; }
        public ICollection<TblTimekeepingSheet> TblTimekeepingSheet { get; set; }
        public ICollection<TblWorkflowStateRightRestriction> TblWorkflowStateRightRestriction { get; set; }
        public ICollection<TblWorkflowStateTransition> TblWorkflowStateTransitionFkNextworkflowstate { get; set; }
        public ICollection<TblWorkflowStateTransition> TblWorkflowStateTransitionFkWorkflowstate { get; set; }
    }
}
