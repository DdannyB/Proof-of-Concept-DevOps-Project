using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblChecklist
    {
        public TblChecklist()
        {
            TblBlindListChecklist = new HashSet<TblBlindListChecklist>();
            TblBlindPointActivityChecklist = new HashSet<TblBlindPointActivityChecklist>();
            TblBlindPointChecklist = new HashSet<TblBlindPointChecklist>();
            TblChangeRequestChecklistUser = new HashSet<TblChangeRequestChecklistUser>();
            TblChecklistItem = new HashSet<TblChecklistItem>();
            TblChecklistShortcode = new HashSet<TblChecklistShortcode>();
            TblReviewSubGroup = new HashSet<TblReviewSubGroup>();
            TblScopeChecklist = new HashSet<TblScopeChecklist>();
            TblTemplateBlindPointActivityChecklist = new HashSet<TblTemplateBlindPointActivityChecklist>();
            TblTemplateBlindPointChecklist = new HashSet<TblTemplateBlindPointChecklist>();
        }

        public long PkChecklistid { get; set; }
        public string Checklistcode { get; set; }
        public string Checklistdescription { get; set; }
        public string Checklistrequireddocumentation { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long Checklisttype { get; set; }
        public bool Isdefaultchecklist { get; set; }
        public int? Applicationchecklisttype { get; set; }
        public int Required { get; set; }
        public bool? Ismandatory { get; set; }

        public ICollection<TblBlindListChecklist> TblBlindListChecklist { get; set; }
        public ICollection<TblBlindPointActivityChecklist> TblBlindPointActivityChecklist { get; set; }
        public ICollection<TblBlindPointChecklist> TblBlindPointChecklist { get; set; }
        public ICollection<TblChangeRequestChecklistUser> TblChangeRequestChecklistUser { get; set; }
        public ICollection<TblChecklistItem> TblChecklistItem { get; set; }
        public ICollection<TblChecklistShortcode> TblChecklistShortcode { get; set; }
        public ICollection<TblReviewSubGroup> TblReviewSubGroup { get; set; }
        public ICollection<TblScopeChecklist> TblScopeChecklist { get; set; }
        public ICollection<TblTemplateBlindPointActivityChecklist> TblTemplateBlindPointActivityChecklist { get; set; }
        public ICollection<TblTemplateBlindPointChecklist> TblTemplateBlindPointChecklist { get; set; }
    }
}
