using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDocumentItem
    {
        public TblDocumentItem()
        {
            TblAttachment = new HashSet<TblAttachment>();
            TblChangeRequestDocumentItem = new HashSet<TblChangeRequestDocumentItem>();
            TblDocumentItemDocumentColumnSubGroup = new HashSet<TblDocumentItemDocumentColumnSubGroup>();
        }

        public long PkDocumentitemid { get; set; }
        public long FkDocumentitemsubgroupid { get; set; }
        public string Documentitemdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDocumentItemSubGroup FkDocumentitemsubgroup { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblChangeRequestDocumentItem> TblChangeRequestDocumentItem { get; set; }
        public ICollection<TblDocumentItemDocumentColumnSubGroup> TblDocumentItemDocumentColumnSubGroup { get; set; }
    }
}
