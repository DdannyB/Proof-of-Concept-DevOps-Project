using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblShortcode
    {
        public TblShortcode()
        {
            TblBasePermitMaintenanceStrategyDetails = new HashSet<TblBasePermitMaintenanceStrategyDetails>();
            TblBudgetTemplate = new HashSet<TblBudgetTemplate>();
            TblChecklistShortcode = new HashSet<TblChecklistShortcode>();
            TblDocumentLabelShortcodeSubDiscipline = new HashSet<TblDocumentLabelShortcodeSubDiscipline>();
            TblLibraryScopeTemplate = new HashSet<TblLibraryScopeTemplate>();
            TblPlantCustomShortcode = new HashSet<TblPlantCustomShortcode>();
            TblPlantData = new HashSet<TblPlantData>();
            TblProgressResponsible = new HashSet<TblProgressResponsible>();
            TblScope = new HashSet<TblScope>();
            TblShortcodeHoGroupSub = new HashSet<TblShortcodeHoGroupSub>();
            TblShortcodeQaqcQuicklist = new HashSet<TblShortcodeQaqcQuicklist>();
            TblShortcodeTemplate = new HashSet<TblShortcodeTemplate>();
            TblUserMemberShortcode = new HashSet<TblUserMemberShortcode>();
        }

        public long PkShortcodeid { get; set; }
        public string Shortcode { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string ShortcodedescriptionL1 { get; set; }
        public long FkEquipmentcodeid { get; set; }
        public string ShortcodedescriptionL2 { get; set; }
        public string ShortcodedescriptionL3 { get; set; }
        public string ShortcodedescriptionL4 { get; set; }
        public string ShortcodedescriptionL5 { get; set; }

        public TblEquipmentCode FkEquipmentcode { get; set; }
        public ICollection<TblBasePermitMaintenanceStrategyDetails> TblBasePermitMaintenanceStrategyDetails { get; set; }
        public ICollection<TblBudgetTemplate> TblBudgetTemplate { get; set; }
        public ICollection<TblChecklistShortcode> TblChecklistShortcode { get; set; }
        public ICollection<TblDocumentLabelShortcodeSubDiscipline> TblDocumentLabelShortcodeSubDiscipline { get; set; }
        public ICollection<TblLibraryScopeTemplate> TblLibraryScopeTemplate { get; set; }
        public ICollection<TblPlantCustomShortcode> TblPlantCustomShortcode { get; set; }
        public ICollection<TblPlantData> TblPlantData { get; set; }
        public ICollection<TblProgressResponsible> TblProgressResponsible { get; set; }
        public ICollection<TblScope> TblScope { get; set; }
        public ICollection<TblShortcodeHoGroupSub> TblShortcodeHoGroupSub { get; set; }
        public ICollection<TblShortcodeQaqcQuicklist> TblShortcodeQaqcQuicklist { get; set; }
        public ICollection<TblShortcodeTemplate> TblShortcodeTemplate { get; set; }
        public ICollection<TblUserMemberShortcode> TblUserMemberShortcode { get; set; }
    }
}
