using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblImportLog
    {
        public long PkImportlogid { get; set; }
        public string Importguid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkImportuserid { get; set; }
        public long FkProjectid { get; set; }

        public TblUser FkImportuser { get; set; }
        public TblProject FkProject { get; set; }
    }
}
