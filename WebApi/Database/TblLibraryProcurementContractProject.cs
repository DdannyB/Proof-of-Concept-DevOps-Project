using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryProcurementContractProject
    {
        public long PkLibraryprocurementcontractprojectid { get; set; }
        public long FkLibraryprocurementcontractid { get; set; }
        public long FkProjectid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblLibraryProcurementContract FkLibraryprocurementcontract { get; set; }
        public TblProject FkProject { get; set; }
    }
}
