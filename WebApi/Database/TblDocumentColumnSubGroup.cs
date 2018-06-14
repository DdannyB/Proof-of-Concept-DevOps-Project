using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDocumentColumnSubGroup
    {
        public TblDocumentColumnSubGroup()
        {
            TblComplexityItemDocumentLabel = new HashSet<TblComplexityItemDocumentLabel>();
            TblDocumentItemDocumentColumnSubGroup = new HashSet<TblDocumentItemDocumentColumnSubGroup>();
        }

        public long PkDocumentcolumnsubgroupid { get; set; }
        public long FkDocumentcolumnmaingroupid { get; set; }
        public string Documentcolumnsubgroupname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDocumentColumnMainGroup FkDocumentcolumnmaingroup { get; set; }
        public ICollection<TblComplexityItemDocumentLabel> TblComplexityItemDocumentLabel { get; set; }
        public ICollection<TblDocumentItemDocumentColumnSubGroup> TblDocumentItemDocumentColumnSubGroup { get; set; }
    }
}
