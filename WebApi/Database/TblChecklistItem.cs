using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblChecklistItem
    {
        public TblChecklistItem()
        {
            TblChangeRequestChecklistItemUser = new HashSet<TblChangeRequestChecklistItemUser>();
        }

        public long PkChecklistitemid { get; set; }
        public long FkChecklistid { get; set; }
        public long FkChecklistitemgroupid { get; set; }
        public string Checklistitemdescription { get; set; }
        public int Sequencenumber { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblChecklist FkChecklist { get; set; }
        public TblChecklistItemGroup FkChecklistitemgroup { get; set; }
        public ICollection<TblChangeRequestChecklistItemUser> TblChangeRequestChecklistItemUser { get; set; }
    }
}
