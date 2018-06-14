using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblRevisionInfo
    {
        public long PkRevisioninfoid { get; set; }
        public int? Revisionnumber { get; set; }
        public string Revisionreason { get; set; }
        public string Revisioncomputer { get; set; }
        public string Revisionuser { get; set; }
        public DateTime? Revisiondate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblLibraryJobRevisionInfo TblLibraryJobRevisionInfo { get; set; }
        public TblLibraryProcurementContractRevisionInfo TblLibraryProcurementContractRevisionInfo { get; set; }
        public TblLibraryScopeTemplateRevisionInfo TblLibraryScopeTemplateRevisionInfo { get; set; }
    }
}
