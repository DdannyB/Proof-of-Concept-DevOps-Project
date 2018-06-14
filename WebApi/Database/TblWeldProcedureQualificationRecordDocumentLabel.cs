using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWeldProcedureQualificationRecordDocumentLabel
    {
        public long PkWeldprocedurequalificationrecorddocumentlabelid { get; set; }
        public long FkWeldprocedurequalificationrecordid { get; set; }
        public long FkDocumentlabelid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDocumentLabel FkDocumentlabel { get; set; }
        public TblWeldProcedureQualificationRecord FkWeldprocedurequalificationrecord { get; set; }
    }
}
