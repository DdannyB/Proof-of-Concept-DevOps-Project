using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDocumentLabelGroup
    {
        public TblDocumentLabelGroup()
        {
            TblDocumentLabel = new HashSet<TblDocumentLabel>();
            TblUserDocumentLabelGroup = new HashSet<TblUserDocumentLabelGroup>();
        }

        public long PkDocumentlabelgroupid { get; set; }
        public string Documentlabelgroup { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblDocumentLabel> TblDocumentLabel { get; set; }
        public ICollection<TblUserDocumentLabelGroup> TblUserDocumentLabelGroup { get; set; }
    }
}
