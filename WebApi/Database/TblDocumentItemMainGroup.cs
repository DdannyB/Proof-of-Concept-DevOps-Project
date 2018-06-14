using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDocumentItemMainGroup
    {
        public TblDocumentItemMainGroup()
        {
            TblDocumentItemSubGroup = new HashSet<TblDocumentItemSubGroup>();
        }

        public long PkDocumentitemmaingroupid { get; set; }
        public string Documentitemmaingroupname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblDocumentItemSubGroup> TblDocumentItemSubGroup { get; set; }
    }
}
