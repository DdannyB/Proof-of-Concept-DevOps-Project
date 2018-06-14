using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDocumentItemSubGroup
    {
        public TblDocumentItemSubGroup()
        {
            TblDocumentItem = new HashSet<TblDocumentItem>();
        }

        public long PkDocumentitemsubgroupid { get; set; }
        public long FkDocumentitemmaingroupid { get; set; }
        public string Documentitemsubgroupname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDocumentItemMainGroup FkDocumentitemmaingroup { get; set; }
        public ICollection<TblDocumentItem> TblDocumentItem { get; set; }
    }
}
