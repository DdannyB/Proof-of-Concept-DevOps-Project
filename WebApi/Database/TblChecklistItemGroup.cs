using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblChecklistItemGroup
    {
        public TblChecklistItemGroup()
        {
            TblChecklistItem = new HashSet<TblChecklistItem>();
            TblChecklistItemGroupReviewSubGroup = new HashSet<TblChecklistItemGroupReviewSubGroup>();
        }

        public long PkChecklistitemgroupid { get; set; }
        public string Checklistitemgroupname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblChecklistItem> TblChecklistItem { get; set; }
        public ICollection<TblChecklistItemGroupReviewSubGroup> TblChecklistItemGroupReviewSubGroup { get; set; }
    }
}
