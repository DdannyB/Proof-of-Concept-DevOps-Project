using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblComplexityItem
    {
        public TblComplexityItem()
        {
            TblChangeRequestComplexityItem = new HashSet<TblChangeRequestComplexityItem>();
            TblComplexityItemDocumentLabel = new HashSet<TblComplexityItemDocumentLabel>();
            TblComplexityItemReviewSubGroup = new HashSet<TblComplexityItemReviewSubGroup>();
            TblReviewComplexityItem = new HashSet<TblReviewComplexityItem>();
        }

        public long PkComplexityitemid { get; set; }
        public long FkComplexityitemsubgroupid { get; set; }
        public string Complexityitemdescription { get; set; }
        public int? Typeid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblComplexityItemSubGroup FkComplexityitemsubgroup { get; set; }
        public ICollection<TblChangeRequestComplexityItem> TblChangeRequestComplexityItem { get; set; }
        public ICollection<TblComplexityItemDocumentLabel> TblComplexityItemDocumentLabel { get; set; }
        public ICollection<TblComplexityItemReviewSubGroup> TblComplexityItemReviewSubGroup { get; set; }
        public ICollection<TblReviewComplexityItem> TblReviewComplexityItem { get; set; }
    }
}
