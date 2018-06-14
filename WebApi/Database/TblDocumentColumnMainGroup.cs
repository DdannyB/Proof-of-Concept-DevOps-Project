using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDocumentColumnMainGroup
    {
        public TblDocumentColumnMainGroup()
        {
            TblDocumentColumnSubGroup = new HashSet<TblDocumentColumnSubGroup>();
        }

        public long PkDocumentcolumnmaingroupid { get; set; }
        public string Documentcolumnmaingroupname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblDocumentColumnSubGroup> TblDocumentColumnSubGroup { get; set; }
    }
}
