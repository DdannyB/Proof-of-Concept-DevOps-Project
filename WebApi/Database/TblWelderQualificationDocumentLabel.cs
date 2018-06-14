using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWelderQualificationDocumentLabel
    {
        public long PkWelderqualificationdocumentlabelid { get; set; }
        public long FkWelderqualificationid { get; set; }
        public long FkDocumentlabelid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDocumentLabel FkDocumentlabel { get; set; }
        public TblWelderQualification FkWelderqualification { get; set; }
    }
}
