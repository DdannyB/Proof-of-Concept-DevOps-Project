using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLislDocumentLabel
    {
        public long PkLisldocumentlabelid { get; set; }
        public long FkLislid { get; set; }
        public long FkDocumentlabelid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDocumentLabel FkDocumentlabel { get; set; }
        public TblLisl FkLisl { get; set; }
    }
}
