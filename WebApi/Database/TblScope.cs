using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScope
    {
        public TblScope()
        {
            InverseFkCompiledscope = new HashSet<TblScope>();
            InverseFkParentscope = new HashSet<TblScope>();
            TblAction = new HashSet<TblAction>();
            TblAttachment = new HashSet<TblAttachment>();
            TblBlindListScope = new HashSet<TblBlindListScope>();
            TblDecision = new HashSet<TblDecision>();
            TblLisl = new HashSet<TblLisl>();
            TblNdeRequest = new HashSet<TblNdeRequest>();
            TblP6sessionPlancard = new HashSet<TblP6sessionPlancard>();
            TblPidRevisionIgnoreUpdate = new HashSet<TblPidRevisionIgnoreUpdate>();
            TblScheduleChange = new HashSet<TblScheduleChange>();
            TblScopeChangeEffect = new HashSet<TblScopeChangeEffect>();
            TblScopeChangeReason = new HashSet<TblScopeChangeReason>();
            TblScopeChecklist = new HashSet<TblScopeChecklist>();
            TblScopeDecisionMaker = new HashSet<TblScopeDecisionMaker>();
            TblScopeDepartment = new HashSet<TblScopeDepartment>();
            TblScopeDocumentLabel = new HashSet<TblScopeDocumentLabel>();
            TblScopeHazard = new HashSet<TblScopeHazard>();
            TblScopeHoGroupSub = new HashSet<TblScopeHoGroupSub>();
            TblScopeJob = new HashSet<TblScopeJob>();
            TblScopeLabel = new HashSet<TblScopeLabel>();
            TblScopeLog = new HashSet<TblScopeLog>();
            TblScopeMaterial = new HashSet<TblScopeMaterial>();
            TblScopeMilestone = new HashSet<TblScopeMilestone>();
            TblScopeMilestone1 = new HashSet<TblScopeMilestone1>();
            TblScopePidRevision = new HashSet<TblScopePidRevision>();
            TblScopePolution = new HashSet<TblScopePolution>();
            TblScopePunchlist = new HashSet<TblScopePunchlist>();
            TblScopeQaqcQuicklist = new HashSet<TblScopeQaqcQuicklist>();
            TblScopeQualityCheck = new HashSet<TblScopeQualityCheck>();
            TblScopeRelationPosition = new HashSet<TblScopeRelationPosition>();
            TblScopeRequestReview = new HashSet<TblScopeRequestReview>();
            TblScopeRequestRevision = new HashSet<TblScopeRequestRevision>();
            TblScopeReview = new HashSet<TblScopeReview>();
            TblScopeScopeCategory = new HashSet<TblScopeScopeCategory>();
            TblScopeScopeCustom = new HashSet<TblScopeScopeCustom>();
            TblScopeScopeQuality = new HashSet<TblScopeScopeQuality>();
            TblScopeSubDiscipline = new HashSet<TblScopeSubDiscipline>();
            TblScopeTagsMisc = new HashSet<TblScopeTagsMisc>();
            TblScopeTestSystem = new HashSet<TblScopeTestSystem>();
            TblScopeWpcode = new HashSet<TblScopeWpcode>();
            TblScopeWpphaseProgress = new HashSet<TblScopeWpphaseProgress>();
            TblWorkpermit = new HashSet<TblWorkpermit>();
            TblWorkpreparationFreezeHistory = new HashSet<TblWorkpreparationFreezeHistory>();
        }

        public long PkScopeid { get; set; }
        public long? FkParentscopeid { get; set; }
        public long FkProjectid { get; set; }
        public long FkPlantdataid { get; set; }
        public long FkShortcodeid { get; set; }
        public long? FkSubsbsid1 { get; set; }
        public long? FkSubsbsid2 { get; set; }
        public long? FkSubsbsid3 { get; set; }
        public long? FkObsid { get; set; }
        public long? FkCbsid { get; set; }
        public long? FkWbsid { get; set; }
        public long? FkWpholderuserid { get; set; }
        public long? FkScopereviewuserid { get; set; }
        public long? FkScoperesponsibleid { get; set; }
        public long? FkScopecodeid { get; set; }
        public long? FkScopetypeid { get; set; }
        public long? FkScopeprioid { get; set; }
        public long? FkAreacodeid { get; set; }
        public long? FkBuildingid { get; set; }
        public long? FkMaindisciplineid { get; set; }
        public long? FkBudgetcodeid { get; set; }
        public long? FkCostindicationrangeid { get; set; }
        public long? FkDecisionitemid { get; set; }
        public long? FkDecisionitemuserid { get; set; }
        public long? FkFreezeuserid { get; set; }
        public long? FkJustificationcomboid { get; set; }
        public long? FkPlantdatamainid { get; set; }
        public long? FkScopestatusid { get; set; }
        public long? FkBudgetcenterallocationid { get; set; }
        public long? FkChangetypeid { get; set; }
        public long? FkContractorid { get; set; }
        public long? FkEquipmentcodeid { get; set; }
        public long? FkMainphaseid { get; set; }
        public long? FkCompiledscopeid { get; set; }
        public long? FkScopeelevationunitofmeasurementid { get; set; }
        public long Scoperequestno { get; set; }
        public int? Scopenr { get; set; }
        public int? Requestnr { get; set; }
        public string Stoppointnr { get; set; }
        public string Wono { get; set; }
        public string Notificationnr { get; set; }
        public string Notificationtype { get; set; }
        public string Stoppointdescr { get; set; }
        public DateTime? Scopefreezedate { get; set; }
        public string Scopefreezememo { get; set; }
        public DateTime? Workpreparationfreezedate { get; set; }
        public DateTime? Isdeleted { get; set; }
        public bool? Isparent { get; set; }
        public DateTime? Isscopechange { get; set; }
        public string Deleteuser { get; set; }
        public bool Iscompiledrequest { get; set; }
        public DateTime? Isexecuted { get; set; }
        public DateTime? Ishold { get; set; }
        public string Optionalscopememo { get; set; }
        public string Additionalinformation { get; set; }
        public string Historymemo { get; set; }
        public string Managementnotes { get; set; }
        public string Remarkrequestor { get; set; }
        public string Fixedscopememo { get; set; }
        public string Evalmemo { get; set; }
        public string Gatekeepermemo { get; set; }
        public string Operationalmemo { get; set; }
        public string Polutionmemo { get; set; }
        public string Requestormemo { get; set; }
        public string Schedulermemo { get; set; }
        public string Inspectionmemo { get; set; }
        public string Shememo { get; set; }
        public string Consequences { get; set; }
        public string Wpholdermemo { get; set; }
        public int? Environmenteffect { get; set; }
        public int? Environmentprob { get; set; }
        public string Environmentresult { get; set; }
        public int? Financialeffect { get; set; }
        public int? Financialprob { get; set; }
        public string Financialresult { get; set; }
        public int? Mitigatedriskeffect { get; set; }
        public int? Mitigatedriskprob { get; set; }
        public string Mitigatedriskresult { get; set; }
        public int? Qualityeffect { get; set; }
        public int? Qualityprob { get; set; }
        public string Qualityresult { get; set; }
        public int? Reputationeffect { get; set; }
        public int? Reputationprob { get; set; }
        public string Reputationresult { get; set; }
        public int? Safetyeffect { get; set; }
        public int? Safetyprob { get; set; }
        public string Safetyresult { get; set; }
        public string Unmitigatedrisk { get; set; }
        public bool Ismaxriskscope { get; set; }
        public string Mr { get; set; }
        public decimal? Ram { get; set; }
        public string Riskreviewedby { get; set; }
        public DateTime? Riskrevieweddate { get; set; }
        public string Ur { get; set; }
        public decimal? Jfactorconsequencecostafter { get; set; }
        public decimal? Jfactorconsequencecostbefore { get; set; }
        public decimal? Jfactormitigatedprob { get; set; }
        public decimal? Jfactorunmitigatedprob { get; set; }
        public DateTime? Decisionitemdate { get; set; }
        public DateTime? Decisionmakerdate { get; set; }
        public DateTime? Exportdate { get; set; }
        public DateTime? Ganttscopestartdate { get; set; }
        public DateTime? Gatekeeperready { get; set; }
        public DateTime? Proposedplannedfinish { get; set; }
        public DateTime? Proposedplannedstart { get; set; }
        public DateTime? Reqexedate { get; set; }
        public DateTime? Scopeitrequestdate { get; set; }
        public DateTime? Scopereleasedate { get; set; }
        public DateTime? Scopestatusdate { get; set; }
        public string Changedby { get; set; }
        public DateTime? Changeddate { get; set; }
        public DateTime? Ho1date { get; set; }
        public DateTime? Ho2date { get; set; }
        public string Ho1user { get; set; }
        public string Ho2user { get; set; }
        public DateTime? Rfrdate { get; set; }
        public bool? Rfr { get; set; }
        public bool Justification1 { get; set; }
        public bool Justification2 { get; set; }
        public bool Justification3 { get; set; }
        public bool Justification4 { get; set; }
        public bool Justification5 { get; set; }
        public bool Justification6 { get; set; }
        public bool Justification7 { get; set; }
        public bool Justification8 { get; set; }
        public string Justificationdescription { get; set; }
        public string Reviewed { get; set; }
        public decimal? Reviewedbutget { get; set; }
        public decimal? Optionalbudget { get; set; }
        public decimal? Reviewedhours { get; set; }
        public double? Bhrsscoping { get; set; }
        public double? Bhrswp { get; set; }
        public string Budgetcenter { get; set; }
        public decimal? Guestimatedcost { get; set; }
        public decimal? Savings { get; set; }
        public bool? Equipmentbypassed { get; set; }
        public bool? Equipmentinservice { get; set; }
        public bool? Equipmentisolated { get; set; }
        public string Materialsmemo { get; set; }
        public string Importguidscopeit { get; set; }
        public string Importguid { get; set; }
        public string Guid { get; set; }
        public string Createdby { get; set; }
        public string Importfiletype { get; set; }
        public string Username { get; set; }
        public string Userstatus { get; set; }
        public string Requestor { get; set; }
        public string Responsible { get; set; }
        public string Exportuser { get; set; }
        public string Phasedescr { get; set; }
        public string Phasenr { get; set; }
        public decimal? Scopeelevation { get; set; }
        public string Scopelocation { get; set; }
        public string Mainplant { get; set; }
        public string Maintenanceplan { get; set; }
        public string Planningplant { get; set; }
        public string Mainworkcenter { get; set; }
        public bool Backupavailability { get; set; }
        public bool Batch { get; set; }
        public string Batterylimit { get; set; }
        public string Cat { get; set; }
        public string Changenrcontractor { get; set; }
        public decimal? Durant { get; set; }
        public string Jobheader { get; set; }
        public bool? Merged { get; set; }
        public string Ordertype { get; set; }
        public string Plannergroup { get; set; }
        public string Ponr { get; set; }
        public string Revisioncode { get; set; }
        public string Rowtype { get; set; }
        public decimal? Rrr { get; set; }
        public int Scopeprogressbar { get; set; }
        public string Systemstatus { get; set; }
        public string Thirdparty { get; set; }
        public string Wbsheader { get; set; }
        public string Wregnr { get; set; }
        public string Wtypenr { get; set; }
        public string Rosersystemsrequestdate { get; set; }
        public bool Visibleinrosersystems { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? Oldrsid { get; set; }
        public long? Oldsiid { get; set; }
        public decimal? Optionalhours { get; set; }
        public DateTime? Originalplannedstart { get; set; }
        public DateTime? Originalplannedfinish { get; set; }
        public DateTime? Lastexporttoscheduleit { get; set; }
        public long? FkArchivecodeid { get; set; }
        public string Archivecodechangeduser { get; set; }
        public DateTime? Archivecodechangeddate { get; set; }
        public long? FkSubprojectid { get; set; }
        public bool Capex { get; set; }
        public bool Opex { get; set; }
        public int Createdin { get; set; }
        public string Instrumentationmemo { get; set; }
        public string Electricalmemo { get; set; }
        public string Maintenancememo { get; set; }
        public string Processtechnologymemo { get; set; }
        public string Civilmemo { get; set; }
        public string Engineeringmemo { get; set; }
        public int? Emergentworktype { get; set; }
        public int? Emergentworkdecisiontype { get; set; }
        public decimal? Estimatedhours { get; set; }
        public int? Emergentworkno { get; set; }
        public long? FkEmergentworkapproveruserid { get; set; }
        public DateTime? Emergentworkapprovedate { get; set; }

        public TblArchiveCode FkArchivecode { get; set; }
        public TblAreaCode FkAreacode { get; set; }
        public TblBudgetCenterAllocation FkBudgetcenterallocation { get; set; }
        public TblBudgetCode FkBudgetcode { get; set; }
        public TblBuilding FkBuilding { get; set; }
        public TblCbs FkCbs { get; set; }
        public TblScope FkCompiledscope { get; set; }
        public TblContractor FkContractor { get; set; }
        public TblCostIndicationRange FkCostindicationrange { get; set; }
        public TblDecisionItem FkDecisionitem { get; set; }
        public TblUser FkDecisionitemuser { get; set; }
        public TblUser FkEmergentworkapproveruser { get; set; }
        public TblEquipmentCode FkEquipmentcode { get; set; }
        public TblUser FkFreezeuser { get; set; }
        public TblJustificationCombo FkJustificationcombo { get; set; }
        public TblMainDiscipline FkMaindiscipline { get; set; }
        public TblMainPhase FkMainphase { get; set; }
        public TblObs FkObs { get; set; }
        public TblScope FkParentscope { get; set; }
        public TblPlantData FkPlantdata { get; set; }
        public TblPlantData FkPlantdatamain { get; set; }
        public TblProject FkProject { get; set; }
        public TblScopeCode FkScopecode { get; set; }
        public TblUnitOfMeasurement FkScopeelevationunitofmeasurement { get; set; }
        public TblScopePrio FkScopeprio { get; set; }
        public TblScopeResponsible FkScoperesponsible { get; set; }
        public TblUser FkScopereviewuser { get; set; }
        public TblScopeStatus FkScopestatus { get; set; }
        public TblScopeType FkScopetype { get; set; }
        public TblShortcode FkShortcode { get; set; }
        public TblSubProject FkSubproject { get; set; }
        public TblSubSbs FkSubsbsid1Navigation { get; set; }
        public TblSubSbs FkSubsbsid2Navigation { get; set; }
        public TblSubSbs FkSubsbsid3Navigation { get; set; }
        public TblWbs FkWbs { get; set; }
        public TblUser FkWpholderuser { get; set; }
        public ICollection<TblScope> InverseFkCompiledscope { get; set; }
        public ICollection<TblScope> InverseFkParentscope { get; set; }
        public ICollection<TblAction> TblAction { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblBlindListScope> TblBlindListScope { get; set; }
        public ICollection<TblDecision> TblDecision { get; set; }
        public ICollection<TblLisl> TblLisl { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequest { get; set; }
        public ICollection<TblP6sessionPlancard> TblP6sessionPlancard { get; set; }
        public ICollection<TblPidRevisionIgnoreUpdate> TblPidRevisionIgnoreUpdate { get; set; }
        public ICollection<TblScheduleChange> TblScheduleChange { get; set; }
        public ICollection<TblScopeChangeEffect> TblScopeChangeEffect { get; set; }
        public ICollection<TblScopeChangeReason> TblScopeChangeReason { get; set; }
        public ICollection<TblScopeChecklist> TblScopeChecklist { get; set; }
        public ICollection<TblScopeDecisionMaker> TblScopeDecisionMaker { get; set; }
        public ICollection<TblScopeDepartment> TblScopeDepartment { get; set; }
        public ICollection<TblScopeDocumentLabel> TblScopeDocumentLabel { get; set; }
        public ICollection<TblScopeHazard> TblScopeHazard { get; set; }
        public ICollection<TblScopeHoGroupSub> TblScopeHoGroupSub { get; set; }
        public ICollection<TblScopeJob> TblScopeJob { get; set; }
        public ICollection<TblScopeLabel> TblScopeLabel { get; set; }
        public ICollection<TblScopeLog> TblScopeLog { get; set; }
        public ICollection<TblScopeMaterial> TblScopeMaterial { get; set; }
        public ICollection<TblScopeMilestone> TblScopeMilestone { get; set; }
        public ICollection<TblScopeMilestone1> TblScopeMilestone1 { get; set; }
        public ICollection<TblScopePidRevision> TblScopePidRevision { get; set; }
        public ICollection<TblScopePolution> TblScopePolution { get; set; }
        public ICollection<TblScopePunchlist> TblScopePunchlist { get; set; }
        public ICollection<TblScopeQaqcQuicklist> TblScopeQaqcQuicklist { get; set; }
        public ICollection<TblScopeQualityCheck> TblScopeQualityCheck { get; set; }
        public ICollection<TblScopeRelationPosition> TblScopeRelationPosition { get; set; }
        public ICollection<TblScopeRequestReview> TblScopeRequestReview { get; set; }
        public ICollection<TblScopeRequestRevision> TblScopeRequestRevision { get; set; }
        public ICollection<TblScopeReview> TblScopeReview { get; set; }
        public ICollection<TblScopeScopeCategory> TblScopeScopeCategory { get; set; }
        public ICollection<TblScopeScopeCustom> TblScopeScopeCustom { get; set; }
        public ICollection<TblScopeScopeQuality> TblScopeScopeQuality { get; set; }
        public ICollection<TblScopeSubDiscipline> TblScopeSubDiscipline { get; set; }
        public ICollection<TblScopeTagsMisc> TblScopeTagsMisc { get; set; }
        public ICollection<TblScopeTestSystem> TblScopeTestSystem { get; set; }
        public ICollection<TblScopeWpcode> TblScopeWpcode { get; set; }
        public ICollection<TblScopeWpphaseProgress> TblScopeWpphaseProgress { get; set; }
        public ICollection<TblWorkpermit> TblWorkpermit { get; set; }
        public ICollection<TblWorkpreparationFreezeHistory> TblWorkpreparationFreezeHistory { get; set; }
    }
}
