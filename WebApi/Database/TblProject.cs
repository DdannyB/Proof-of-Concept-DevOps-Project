using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblProject
    {
        public TblProject()
        {
            TblBasicListSignbox = new HashSet<TblBasicListSignbox>();
            TblBlindList = new HashSet<TblBlindList>();
            TblBlindProjectMainPhaseSubPhaseReleaseFinish = new HashSet<TblBlindProjectMainPhaseSubPhaseReleaseFinish>();
            TblCbs = new HashSet<TblCbs>();
            TblCertificate = new HashSet<TblCertificate>();
            TblCustomColumn = new HashSet<TblCustomColumn>();
            TblDeadline = new HashSet<TblDeadline>();
            TblDeliverable = new HashSet<TblDeliverable>();
            TblExceptionProject = new HashSet<TblExceptionProject>();
            TblForecastUsersHrsWeek = new HashSet<TblForecastUsersHrsWeek>();
            TblForecastUsersQtyWeek = new HashSet<TblForecastUsersQtyWeek>();
            TblForecastWpphases = new HashSet<TblForecastWpphases>();
            TblGridAdvViewinfo = new HashSet<TblGridAdvViewinfo>();
            TblGridFilterinfo = new HashSet<TblGridFilterinfo>();
            TblGridViewInfoActiveGridFilterInfo = new HashSet<TblGridViewInfoActiveGridFilterInfo>();
            TblHandoverGroupMain = new HashSet<TblHandoverGroupMain>();
            TblImportLog = new HashSet<TblImportLog>();
            TblLabel = new HashSet<TblLabel>();
            TblLibraryActiveScopeTemplateActive = new HashSet<TblLibraryActiveScopeTemplateActive>();
            TblLibraryProcurementContract = new HashSet<TblLibraryProcurementContract>();
            TblLibraryProcurementContractProject = new HashSet<TblLibraryProcurementContractProject>();
            TblLibraryScopeTemplate = new HashSet<TblLibraryScopeTemplate>();
            TblLibraryScopeTemplateProject = new HashSet<TblLibraryScopeTemplateProject>();
            TblLisl = new HashSet<TblLisl>();
            TblMaterialSource = new HashSet<TblMaterialSource>();
            TblMilestone = new HashSet<TblMilestone>();
            TblNdeBatch = new HashSet<TblNdeBatch>();
            TblNdeRequest = new HashSet<TblNdeRequest>();
            TblObs = new HashSet<TblObs>();
            TblP6session = new HashSet<TblP6session>();
            TblPermit = new HashSet<TblPermit>();
            TblPosition = new HashSet<TblPosition>();
            TblPrimaveraAnalysis = new HashSet<TblPrimaveraAnalysis>();
            TblProgressBatch = new HashSet<TblProgressBatch>();
            TblProgressResponsible = new HashSet<TblProgressResponsible>();
            TblProjectOrganisation = new HashSet<TblProjectOrganisation>();
            TblProjectWorkflow = new HashSet<TblProjectWorkflow>();
            TblProjectXrefFkLinkedproject = new HashSet<TblProjectXref>();
            TblProjectXrefFkProject = new HashSet<TblProjectXref>();
            TblPropack = new HashSet<TblPropack>();
            TblPropackTemplate = new HashSet<TblPropackTemplate>();
            TblPunchCategory = new HashSet<TblPunchCategory>();
            TblPushJob = new HashSet<TblPushJob>();
            TblQaqcQuicklist = new HashSet<TblQaqcQuicklist>();
            TblQuotationRequest = new HashSet<TblQuotationRequest>();
            TblReportView = new HashSet<TblReportView>();
            TblResourceConstraint = new HashSet<TblResourceConstraint>();
            TblScheduleChangeProject = new HashSet<TblScheduleChangeProject>();
            TblScope = new HashSet<TblScope>();
            TblScopeQuality = new HashSet<TblScopeQuality>();
            TblSetting1 = new HashSet<TblSetting1>();
            TblShortcodeHoGroupSub = new HashSet<TblShortcodeHoGroupSub>();
            TblShortcodeQaqcQuicklist = new HashSet<TblShortcodeQaqcQuicklist>();
            TblShortcodeTemplate = new HashSet<TblShortcodeTemplate>();
            TblSnapshot = new HashSet<TblSnapshot>();
            TblSubProject = new HashSet<TblSubProject>();
            TblTarget = new HashSet<TblTarget>();
            TblTemplateMilestone = new HashSet<TblTemplateMilestone>();
            TblTimekeepingEntry = new HashSet<TblTimekeepingEntry>();
            TblTimekeepingMileage = new HashSet<TblTimekeepingMileage>();
            TblTimekeepingSheet = new HashSet<TblTimekeepingSheet>();
            TblUser = new HashSet<TblUser>();
            TblUserApplicationProject = new HashSet<TblUserApplicationProject>();
            TblUserDepartment = new HashSet<TblUserDepartment>();
            TblUserDocumentLabelGroup = new HashSet<TblUserDocumentLabelGroup>();
            TblUserLislProgressPhase = new HashSet<TblUserLislProgressPhase>();
            TblUserLogin = new HashSet<TblUserLogin>();
            TblUserMemberContractor = new HashSet<TblUserMemberContractor>();
            TblUserMemberDiscipline = new HashSet<TblUserMemberDiscipline>();
            TblUserMemberQcResource = new HashSet<TblUserMemberQcResource>();
            TblUserMemberShortcode = new HashSet<TblUserMemberShortcode>();
            TblUserMemberWpcode = new HashSet<TblUserMemberWpcode>();
            TblUserPermitFunctionGroup = new HashSet<TblUserPermitFunctionGroup>();
            TblUserProjectOrganisationStructure = new HashSet<TblUserProjectOrganisationStructure>();
            TblUserSecurity = new HashSet<TblUserSecurity>();
            TblUserSetting = new HashSet<TblUserSetting>();
            TblWallpaper = new HashSet<TblWallpaper>();
            TblWbs = new HashSet<TblWbs>();
            TblWeldProcedureSpecification = new HashSet<TblWeldProcedureSpecification>();
            TblWelderProject = new HashSet<TblWelderProject>();
            TblWorkPreparationCode = new HashSet<TblWorkPreparationCode>();
            TblWorkPreparationPhase = new HashSet<TblWorkPreparationPhase>();
        }

        public long PkProjectid { get; set; }
        public string Projectcode { get; set; }
        public string Projectdescription { get; set; }
        public string Notes { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Scopeitrequestcode { get; set; }
        public long? FkLogoid { get; set; }
        public DateTime? Activeuntilldate { get; set; }
        public DateTime? Projectstartdate { get; set; }
        public DateTime? Projectenddate { get; set; }
        public DateTime? Rasprefabdate { get; set; }
        public DateTime? Rasconstructiondate { get; set; }
        public string Year { get; set; }
        public long FkDefaultcalendarid { get; set; }
        public DateTime? Projectearlystart { get; set; }
        public DateTime? Projectlatefinish { get; set; }
        public int? Durationprecision { get; set; }
        public DateTime? Projectearlyfinish { get; set; }
        public DateTime? Projectlatestart { get; set; }
        public string Lastsuccessfulprioritylist { get; set; }
        public long FkNormsetid { get; set; }
        public long? FkBranchid { get; set; }
        public int Isolationlistfrozenstatus { get; set; }
        public bool Showesthrsintimeentry { get; set; }
        public bool Allowprojectscopetemplates { get; set; }
        public bool FreezeAllowWithoutDecision { get; set; }
        public string Projectchangetrackingdescription { get; set; }
        public long FkSnapshotactualscheduleitid { get; set; }
        public long FkSnapshotbaselinescheduleitid { get; set; }
        public long FkSnapshotbaselinesystemsid { get; set; }
        public long FkSnapshotactualsystemsid { get; set; }
        public string Materialrequestcode { get; set; }
        public int Phaseblockingbehaviour { get; set; }
        public int? Pidtextmode { get; set; }
        public int? Pidshowcombiicon { get; set; }
        public bool Webtimeregistrationenabled { get; set; }
        public bool Ismobileproject { get; set; }

        public TblBranch FkBranch { get; set; }
        public TblCalendar FkDefaultcalendar { get; set; }
        public TblLogo FkLogo { get; set; }
        public TblNormset FkNormset { get; set; }
        public TblSnapshot FkSnapshotactualscheduleit { get; set; }
        public TblSnapshot FkSnapshotactualsystems { get; set; }
        public TblSnapshot FkSnapshotbaselinescheduleit { get; set; }
        public TblSnapshot FkSnapshotbaselinesystems { get; set; }
        public ICollection<TblBasicListSignbox> TblBasicListSignbox { get; set; }
        public ICollection<TblBlindList> TblBlindList { get; set; }
        public ICollection<TblBlindProjectMainPhaseSubPhaseReleaseFinish> TblBlindProjectMainPhaseSubPhaseReleaseFinish { get; set; }
        public ICollection<TblCbs> TblCbs { get; set; }
        public ICollection<TblCertificate> TblCertificate { get; set; }
        public ICollection<TblCustomColumn> TblCustomColumn { get; set; }
        public ICollection<TblDeadline> TblDeadline { get; set; }
        public ICollection<TblDeliverable> TblDeliverable { get; set; }
        public ICollection<TblExceptionProject> TblExceptionProject { get; set; }
        public ICollection<TblForecastUsersHrsWeek> TblForecastUsersHrsWeek { get; set; }
        public ICollection<TblForecastUsersQtyWeek> TblForecastUsersQtyWeek { get; set; }
        public ICollection<TblForecastWpphases> TblForecastWpphases { get; set; }
        public ICollection<TblGridAdvViewinfo> TblGridAdvViewinfo { get; set; }
        public ICollection<TblGridFilterinfo> TblGridFilterinfo { get; set; }
        public ICollection<TblGridViewInfoActiveGridFilterInfo> TblGridViewInfoActiveGridFilterInfo { get; set; }
        public ICollection<TblHandoverGroupMain> TblHandoverGroupMain { get; set; }
        public ICollection<TblImportLog> TblImportLog { get; set; }
        public ICollection<TblLabel> TblLabel { get; set; }
        public ICollection<TblLibraryActiveScopeTemplateActive> TblLibraryActiveScopeTemplateActive { get; set; }
        public ICollection<TblLibraryProcurementContract> TblLibraryProcurementContract { get; set; }
        public ICollection<TblLibraryProcurementContractProject> TblLibraryProcurementContractProject { get; set; }
        public ICollection<TblLibraryScopeTemplate> TblLibraryScopeTemplate { get; set; }
        public ICollection<TblLibraryScopeTemplateProject> TblLibraryScopeTemplateProject { get; set; }
        public ICollection<TblLisl> TblLisl { get; set; }
        public ICollection<TblMaterialSource> TblMaterialSource { get; set; }
        public ICollection<TblMilestone> TblMilestone { get; set; }
        public ICollection<TblNdeBatch> TblNdeBatch { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequest { get; set; }
        public ICollection<TblObs> TblObs { get; set; }
        public ICollection<TblP6session> TblP6session { get; set; }
        public ICollection<TblPermit> TblPermit { get; set; }
        public ICollection<TblPosition> TblPosition { get; set; }
        public ICollection<TblPrimaveraAnalysis> TblPrimaveraAnalysis { get; set; }
        public ICollection<TblProgressBatch> TblProgressBatch { get; set; }
        public ICollection<TblProgressResponsible> TblProgressResponsible { get; set; }
        public ICollection<TblProjectOrganisation> TblProjectOrganisation { get; set; }
        public ICollection<TblProjectWorkflow> TblProjectWorkflow { get; set; }
        public ICollection<TblProjectXref> TblProjectXrefFkLinkedproject { get; set; }
        public ICollection<TblProjectXref> TblProjectXrefFkProject { get; set; }
        public ICollection<TblPropack> TblPropack { get; set; }
        public ICollection<TblPropackTemplate> TblPropackTemplate { get; set; }
        public ICollection<TblPunchCategory> TblPunchCategory { get; set; }
        public ICollection<TblPushJob> TblPushJob { get; set; }
        public ICollection<TblQaqcQuicklist> TblQaqcQuicklist { get; set; }
        public ICollection<TblQuotationRequest> TblQuotationRequest { get; set; }
        public ICollection<TblReportView> TblReportView { get; set; }
        public ICollection<TblResourceConstraint> TblResourceConstraint { get; set; }
        public ICollection<TblScheduleChangeProject> TblScheduleChangeProject { get; set; }
        public ICollection<TblScope> TblScope { get; set; }
        public ICollection<TblScopeQuality> TblScopeQuality { get; set; }
        public ICollection<TblSetting1> TblSetting1 { get; set; }
        public ICollection<TblShortcodeHoGroupSub> TblShortcodeHoGroupSub { get; set; }
        public ICollection<TblShortcodeQaqcQuicklist> TblShortcodeQaqcQuicklist { get; set; }
        public ICollection<TblShortcodeTemplate> TblShortcodeTemplate { get; set; }
        public ICollection<TblSnapshot> TblSnapshot { get; set; }
        public ICollection<TblSubProject> TblSubProject { get; set; }
        public ICollection<TblTarget> TblTarget { get; set; }
        public ICollection<TblTemplateMilestone> TblTemplateMilestone { get; set; }
        public ICollection<TblTimekeepingEntry> TblTimekeepingEntry { get; set; }
        public ICollection<TblTimekeepingMileage> TblTimekeepingMileage { get; set; }
        public ICollection<TblTimekeepingSheet> TblTimekeepingSheet { get; set; }
        public ICollection<TblUser> TblUser { get; set; }
        public ICollection<TblUserApplicationProject> TblUserApplicationProject { get; set; }
        public ICollection<TblUserDepartment> TblUserDepartment { get; set; }
        public ICollection<TblUserDocumentLabelGroup> TblUserDocumentLabelGroup { get; set; }
        public ICollection<TblUserLislProgressPhase> TblUserLislProgressPhase { get; set; }
        public ICollection<TblUserLogin> TblUserLogin { get; set; }
        public ICollection<TblUserMemberContractor> TblUserMemberContractor { get; set; }
        public ICollection<TblUserMemberDiscipline> TblUserMemberDiscipline { get; set; }
        public ICollection<TblUserMemberQcResource> TblUserMemberQcResource { get; set; }
        public ICollection<TblUserMemberShortcode> TblUserMemberShortcode { get; set; }
        public ICollection<TblUserMemberWpcode> TblUserMemberWpcode { get; set; }
        public ICollection<TblUserPermitFunctionGroup> TblUserPermitFunctionGroup { get; set; }
        public ICollection<TblUserProjectOrganisationStructure> TblUserProjectOrganisationStructure { get; set; }
        public ICollection<TblUserSecurity> TblUserSecurity { get; set; }
        public ICollection<TblUserSetting> TblUserSetting { get; set; }
        public ICollection<TblWallpaper> TblWallpaper { get; set; }
        public ICollection<TblWbs> TblWbs { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecification { get; set; }
        public ICollection<TblWelderProject> TblWelderProject { get; set; }
        public ICollection<TblWorkPreparationCode> TblWorkPreparationCode { get; set; }
        public ICollection<TblWorkPreparationPhase> TblWorkPreparationPhase { get; set; }
    }
}
