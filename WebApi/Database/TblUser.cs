using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblActionFkActionbyuser = new HashSet<TblAction>();
            TblActionFkActionholderuser = new HashSet<TblAction>();
            TblBlindListChecklist = new HashSet<TblBlindListChecklist>();
            TblBlindPointActivity = new HashSet<TblBlindPointActivity>();
            TblBlindPointActivityChecklist = new HashSet<TblBlindPointActivityChecklist>();
            TblBlindPointChecklist = new HashSet<TblBlindPointChecklist>();
            TblCertificate = new HashSet<TblCertificate>();
            TblCertificateInspection = new HashSet<TblCertificateInspection>();
            TblChangeRequestActionFkInitiatinguser = new HashSet<TblChangeRequestAction>();
            TblChangeRequestActionFkReadyuser = new HashSet<TblChangeRequestAction>();
            TblChangeRequestActionFkResponsibleuser = new HashSet<TblChangeRequestAction>();
            TblChangeRequestChecklistItemUser = new HashSet<TblChangeRequestChecklistItemUser>();
            TblChangeRequestChecklistUser = new HashSet<TblChangeRequestChecklistUser>();
            TblChangeRequestFkDocumentcontroller = new HashSet<TblChangeRequest>();
            TblChangeRequestFkRequestor = new HashSet<TblChangeRequest>();
            TblChangeRequestFkResponsible = new HashSet<TblChangeRequest>();
            TblChangeRequestLog = new HashSet<TblChangeRequestLog>();
            TblColumnDisplayFormat = new HashSet<TblColumnDisplayFormat>();
            TblCurveStyle = new HashSet<TblCurveStyle>();
            TblDataExchangeObjectTypeUser = new HashSet<TblDataExchangeObjectTypeUser>();
            TblDataExchangeStagingTableUser = new HashSet<TblDataExchangeStagingTableUser>();
            TblDecision = new HashSet<TblDecision>();
            TblDigitalSignature = new HashSet<TblDigitalSignature>();
            TblForecastUsersHrsWeek = new HashSet<TblForecastUsersHrsWeek>();
            TblForecastUsersQtyWeek = new HashSet<TblForecastUsersQtyWeek>();
            TblGridAdvViewinfo = new HashSet<TblGridAdvViewinfo>();
            TblGridFilterinfo = new HashSet<TblGridFilterinfo>();
            TblGridViewinfo = new HashSet<TblGridViewinfo>();
            TblImportLog = new HashSet<TblImportLog>();
            TblIsolationActivityRevertReason = new HashSet<TblIsolationActivityRevertReason>();
            TblLislFkRequestor = new HashSet<TblLisl>();
            TblLislFkScopechangeuser = new HashSet<TblLisl>();
            TblLislNdeInspectionPlan = new HashSet<TblLislNdeInspectionPlan>();
            TblLogging = new HashSet<TblLogging>();
            TblMaterialFkFollowupuser = new HashSet<TblMaterial>();
            TblMaterialFkUser = new HashSet<TblMaterial>();
            TblMyIsolationlist = new HashSet<TblMyIsolationlist>();
            TblNdeBatch = new HashSet<TblNdeBatch>();
            TblNdeRequestFkAcknowledgebyuser = new HashSet<TblNdeRequest>();
            TblNdeRequestFkCancelbyuser = new HashSet<TblNdeRequest>();
            TblNdeRequestFkReadybyuser = new HashSet<TblNdeRequest>();
            TblNdeRequestFkRequestbyuser = new HashSet<TblNdeRequest>();
            TblPasswordHistory = new HashSet<TblPasswordHistory>();
            TblPermitHorizontalClusterStrategy = new HashSet<TblPermitHorizontalClusterStrategy>();
            TblPermitMessage = new HashSet<TblPermitMessage>();
            TblPermitWorkflowState = new HashSet<TblPermitWorkflowState>();
            TblPidRevision = new HashSet<TblPidRevision>();
            TblPlaylist = new HashSet<TblPlaylist>();
            TblProcessAreaRestrictedRightUserProcessArea = new HashSet<TblProcessAreaRestrictedRightUserProcessArea>();
            TblProcessAreaUser = new HashSet<TblProcessAreaUser>();
            TblProgressResponsible = new HashSet<TblProgressResponsible>();
            TblPushJob = new HashSet<TblPushJob>();
            TblPushUser = new HashSet<TblPushUser>();
            TblQuotationRequest = new HashSet<TblQuotationRequest>();
            TblReleaseForPermit = new HashSet<TblReleaseForPermit>();
            TblReportView = new HashSet<TblReportView>();
            TblReview = new HashSet<TblReview>();
            TblRevisionChange = new HashSet<TblRevisionChange>();
            TblRevisionFeedback = new HashSet<TblRevisionFeedback>();
            TblScopeChecklistFkNeededuser = new HashSet<TblScopeChecklist>();
            TblScopeChecklistFkReceiveduser = new HashSet<TblScopeChecklist>();
            TblScopeDecisionMaker = new HashSet<TblScopeDecisionMaker>();
            TblScopeFkDecisionitemuser = new HashSet<TblScope>();
            TblScopeFkEmergentworkapproveruser = new HashSet<TblScope>();
            TblScopeFkFreezeuser = new HashSet<TblScope>();
            TblScopeFkScopereviewuser = new HashSet<TblScope>();
            TblScopeFkWpholderuser = new HashSet<TblScope>();
            TblScopeInput = new HashSet<TblScopeInput>();
            TblScopeQualityCheck = new HashSet<TblScopeQualityCheck>();
            TblScopeRequestReview = new HashSet<TblScopeRequestReview>();
            TblScopeReview = new HashSet<TblScopeReview>();
            TblScopeWpcode = new HashSet<TblScopeWpcode>();
            TblShortcodeTemplateWpcode = new HashSet<TblShortcodeTemplateWpcode>();
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointActivityChecklist = new HashSet<TblTemplateBlindPointActivityChecklist>();
            TblTemplateBlindPointChecklist = new HashSet<TblTemplateBlindPointChecklist>();
            TblTimekeeping = new HashSet<TblTimekeeping>();
            TblTimekeepingEntry = new HashSet<TblTimekeepingEntry>();
            TblTimekeepingMileage = new HashSet<TblTimekeepingMileage>();
            TblTimekeepingSheet = new HashSet<TblTimekeepingSheet>();
            TblToken = new HashSet<TblToken>();
            TblUserApplicationProject = new HashSet<TblUserApplicationProject>();
            TblUserContractorField = new HashSet<TblUserContractorField>();
            TblUserDepartment = new HashSet<TblUserDepartment>();
            TblUserDepartmentSection = new HashSet<TblUserDepartmentSection>();
            TblUserDocumentLabelGroup = new HashSet<TblUserDocumentLabelGroup>();
            TblUserLislProgressPhase = new HashSet<TblUserLislProgressPhase>();
            TblUserLoginFkKickedbyuser = new HashSet<TblUserLogin>();
            TblUserLoginFkUser = new HashSet<TblUserLogin>();
            TblUserMemberContractor = new HashSet<TblUserMemberContractor>();
            TblUserMemberDiscipline = new HashSet<TblUserMemberDiscipline>();
            TblUserMemberQcResource = new HashSet<TblUserMemberQcResource>();
            TblUserMemberShortcode = new HashSet<TblUserMemberShortcode>();
            TblUserMemberWpcode = new HashSet<TblUserMemberWpcode>();
            TblUserPermitFunctionGroup = new HashSet<TblUserPermitFunctionGroup>();
            TblUserProjectOrganisationStructure = new HashSet<TblUserProjectOrganisationStructure>();
            TblUserReviewSubGroup = new HashSet<TblUserReviewSubGroup>();
            TblUserSecurity = new HashSet<TblUserSecurity>();
            TblUserSetting = new HashSet<TblUserSetting>();
            TblUserTimekeepingPeriod = new HashSet<TblUserTimekeepingPeriod>();
            TblViewLayout = new HashSet<TblViewLayout>();
            TblWeldConnectionFkPwhtreadyby = new HashSet<TblWeldConnection>();
            TblWeldConnectionFkReadybyNavigation = new HashSet<TblWeldConnection>();
        }

        public long PkUserid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Firstname { get; set; }
        public string Preposition { get; set; }
        public string Lastname { get; set; }
        public string Sex { get; set; }
        public string Street { get; set; }
        public int? Housenumber { get; set; }
        public string Housenumberext { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public byte[] Photo { get; set; }
        public string Phonenumberhome { get; set; }
        public string Phonenumberwork { get; set; }
        public string Cellphonenumberhome { get; set; }
        public string Cellphonenumberwork { get; set; }
        public string Emailaddresshome { get; set; }
        public string Emailaddresswork { get; set; }
        public bool Isactive { get; set; }
        public string Fax { get; set; }
        public DateTime? Dateofbirth { get; set; }
        public string Placeofbirth { get; set; }
        public string Nationality { get; set; }
        public string Passportnumber { get; set; }
        public string Driverslicense { get; set; }
        public string Autologonname { get; set; }
        public long? FkContractorid { get; set; }
        public string Pincode { get; set; }
        public string Fiscalnr { get; set; }
        public string Socialnr { get; set; }
        public string Memo { get; set; }
        public string Userfunction { get; set; }
        public string Carlicenseplate { get; set; }
        public string Safetytraining { get; set; }
        public DateTime? Cardissueddate { get; set; }
        public DateTime? Cardreturneddate { get; set; }
        public string Cardcustombarcode { get; set; }
        public long? FkSubcontractorid { get; set; }
        public string Humanresourcenr { get; set; }
        public long FkLanguageid { get; set; }
        public long FkApplicationcreatedid { get; set; }
        public long? FkTimekeepingprojectid { get; set; }
        public long? FkTimekeepingresourceid { get; set; }
        public long? FkTimekeepingsubcodeid { get; set; }
        public byte[] Signaturestamp { get; set; }
        public bool? Isfirstlogon { get; set; }
        public DateTime? Passwordmodified { get; set; }
        public string Department { get; set; }
        public string Loginattempt { get; set; }
        public DateTime? Permissionschanged { get; set; }
        public bool Isreadonly { get; set; }
        public string Templockeduntil { get; set; }

        public TblApplication FkApplicationcreated { get; set; }
        public TblContractor FkContractor { get; set; }
        public TblLanguage FkLanguage { get; set; }
        public TblContractor FkSubcontractor { get; set; }
        public TblProject FkTimekeepingproject { get; set; }
        public TblResource FkTimekeepingresource { get; set; }
        public TblTimekeepingSubCode FkTimekeepingsubcode { get; set; }
        public ICollection<TblAction> TblActionFkActionbyuser { get; set; }
        public ICollection<TblAction> TblActionFkActionholderuser { get; set; }
        public ICollection<TblBlindListChecklist> TblBlindListChecklist { get; set; }
        public ICollection<TblBlindPointActivity> TblBlindPointActivity { get; set; }
        public ICollection<TblBlindPointActivityChecklist> TblBlindPointActivityChecklist { get; set; }
        public ICollection<TblBlindPointChecklist> TblBlindPointChecklist { get; set; }
        public ICollection<TblCertificate> TblCertificate { get; set; }
        public ICollection<TblCertificateInspection> TblCertificateInspection { get; set; }
        public ICollection<TblChangeRequestAction> TblChangeRequestActionFkInitiatinguser { get; set; }
        public ICollection<TblChangeRequestAction> TblChangeRequestActionFkReadyuser { get; set; }
        public ICollection<TblChangeRequestAction> TblChangeRequestActionFkResponsibleuser { get; set; }
        public ICollection<TblChangeRequestChecklistItemUser> TblChangeRequestChecklistItemUser { get; set; }
        public ICollection<TblChangeRequestChecklistUser> TblChangeRequestChecklistUser { get; set; }
        public ICollection<TblChangeRequest> TblChangeRequestFkDocumentcontroller { get; set; }
        public ICollection<TblChangeRequest> TblChangeRequestFkRequestor { get; set; }
        public ICollection<TblChangeRequest> TblChangeRequestFkResponsible { get; set; }
        public ICollection<TblChangeRequestLog> TblChangeRequestLog { get; set; }
        public ICollection<TblColumnDisplayFormat> TblColumnDisplayFormat { get; set; }
        public ICollection<TblCurveStyle> TblCurveStyle { get; set; }
        public ICollection<TblDataExchangeObjectTypeUser> TblDataExchangeObjectTypeUser { get; set; }
        public ICollection<TblDataExchangeStagingTableUser> TblDataExchangeStagingTableUser { get; set; }
        public ICollection<TblDecision> TblDecision { get; set; }
        public ICollection<TblDigitalSignature> TblDigitalSignature { get; set; }
        public ICollection<TblForecastUsersHrsWeek> TblForecastUsersHrsWeek { get; set; }
        public ICollection<TblForecastUsersQtyWeek> TblForecastUsersQtyWeek { get; set; }
        public ICollection<TblGridAdvViewinfo> TblGridAdvViewinfo { get; set; }
        public ICollection<TblGridFilterinfo> TblGridFilterinfo { get; set; }
        public ICollection<TblGridViewinfo> TblGridViewinfo { get; set; }
        public ICollection<TblImportLog> TblImportLog { get; set; }
        public ICollection<TblIsolationActivityRevertReason> TblIsolationActivityRevertReason { get; set; }
        public ICollection<TblLisl> TblLislFkRequestor { get; set; }
        public ICollection<TblLisl> TblLislFkScopechangeuser { get; set; }
        public ICollection<TblLislNdeInspectionPlan> TblLislNdeInspectionPlan { get; set; }
        public ICollection<TblLogging> TblLogging { get; set; }
        public ICollection<TblMaterial> TblMaterialFkFollowupuser { get; set; }
        public ICollection<TblMaterial> TblMaterialFkUser { get; set; }
        public ICollection<TblMyIsolationlist> TblMyIsolationlist { get; set; }
        public ICollection<TblNdeBatch> TblNdeBatch { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequestFkAcknowledgebyuser { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequestFkCancelbyuser { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequestFkReadybyuser { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequestFkRequestbyuser { get; set; }
        public ICollection<TblPasswordHistory> TblPasswordHistory { get; set; }
        public ICollection<TblPermitHorizontalClusterStrategy> TblPermitHorizontalClusterStrategy { get; set; }
        public ICollection<TblPermitMessage> TblPermitMessage { get; set; }
        public ICollection<TblPermitWorkflowState> TblPermitWorkflowState { get; set; }
        public ICollection<TblPidRevision> TblPidRevision { get; set; }
        public ICollection<TblPlaylist> TblPlaylist { get; set; }
        public ICollection<TblProcessAreaRestrictedRightUserProcessArea> TblProcessAreaRestrictedRightUserProcessArea { get; set; }
        public ICollection<TblProcessAreaUser> TblProcessAreaUser { get; set; }
        public ICollection<TblProgressResponsible> TblProgressResponsible { get; set; }
        public ICollection<TblPushJob> TblPushJob { get; set; }
        public ICollection<TblPushUser> TblPushUser { get; set; }
        public ICollection<TblQuotationRequest> TblQuotationRequest { get; set; }
        public ICollection<TblReleaseForPermit> TblReleaseForPermit { get; set; }
        public ICollection<TblReportView> TblReportView { get; set; }
        public ICollection<TblReview> TblReview { get; set; }
        public ICollection<TblRevisionChange> TblRevisionChange { get; set; }
        public ICollection<TblRevisionFeedback> TblRevisionFeedback { get; set; }
        public ICollection<TblScopeChecklist> TblScopeChecklistFkNeededuser { get; set; }
        public ICollection<TblScopeChecklist> TblScopeChecklistFkReceiveduser { get; set; }
        public ICollection<TblScopeDecisionMaker> TblScopeDecisionMaker { get; set; }
        public ICollection<TblScope> TblScopeFkDecisionitemuser { get; set; }
        public ICollection<TblScope> TblScopeFkEmergentworkapproveruser { get; set; }
        public ICollection<TblScope> TblScopeFkFreezeuser { get; set; }
        public ICollection<TblScope> TblScopeFkScopereviewuser { get; set; }
        public ICollection<TblScope> TblScopeFkWpholderuser { get; set; }
        public ICollection<TblScopeInput> TblScopeInput { get; set; }
        public ICollection<TblScopeQualityCheck> TblScopeQualityCheck { get; set; }
        public ICollection<TblScopeRequestReview> TblScopeRequestReview { get; set; }
        public ICollection<TblScopeReview> TblScopeReview { get; set; }
        public ICollection<TblScopeWpcode> TblScopeWpcode { get; set; }
        public ICollection<TblShortcodeTemplateWpcode> TblShortcodeTemplateWpcode { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPoint { get; set; }
        public ICollection<TblTemplateBlindPointActivityChecklist> TblTemplateBlindPointActivityChecklist { get; set; }
        public ICollection<TblTemplateBlindPointChecklist> TblTemplateBlindPointChecklist { get; set; }
        public ICollection<TblTimekeeping> TblTimekeeping { get; set; }
        public ICollection<TblTimekeepingEntry> TblTimekeepingEntry { get; set; }
        public ICollection<TblTimekeepingMileage> TblTimekeepingMileage { get; set; }
        public ICollection<TblTimekeepingSheet> TblTimekeepingSheet { get; set; }
        public ICollection<TblToken> TblToken { get; set; }
        public ICollection<TblUserApplicationProject> TblUserApplicationProject { get; set; }
        public ICollection<TblUserContractorField> TblUserContractorField { get; set; }
        public ICollection<TblUserDepartment> TblUserDepartment { get; set; }
        public ICollection<TblUserDepartmentSection> TblUserDepartmentSection { get; set; }
        public ICollection<TblUserDocumentLabelGroup> TblUserDocumentLabelGroup { get; set; }
        public ICollection<TblUserLislProgressPhase> TblUserLislProgressPhase { get; set; }
        public ICollection<TblUserLogin> TblUserLoginFkKickedbyuser { get; set; }
        public ICollection<TblUserLogin> TblUserLoginFkUser { get; set; }
        public ICollection<TblUserMemberContractor> TblUserMemberContractor { get; set; }
        public ICollection<TblUserMemberDiscipline> TblUserMemberDiscipline { get; set; }
        public ICollection<TblUserMemberQcResource> TblUserMemberQcResource { get; set; }
        public ICollection<TblUserMemberShortcode> TblUserMemberShortcode { get; set; }
        public ICollection<TblUserMemberWpcode> TblUserMemberWpcode { get; set; }
        public ICollection<TblUserPermitFunctionGroup> TblUserPermitFunctionGroup { get; set; }
        public ICollection<TblUserProjectOrganisationStructure> TblUserProjectOrganisationStructure { get; set; }
        public ICollection<TblUserReviewSubGroup> TblUserReviewSubGroup { get; set; }
        public ICollection<TblUserSecurity> TblUserSecurity { get; set; }
        public ICollection<TblUserSetting> TblUserSetting { get; set; }
        public ICollection<TblUserTimekeepingPeriod> TblUserTimekeepingPeriod { get; set; }
        public ICollection<TblViewLayout> TblViewLayout { get; set; }
        public ICollection<TblWeldConnection> TblWeldConnectionFkPwhtreadyby { get; set; }
        public ICollection<TblWeldConnection> TblWeldConnectionFkReadybyNavigation { get; set; }
    }
}
