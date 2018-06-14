using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryProcurementContractRevisionInfo
    {
        public TblLibraryProcurementContractRevisionInfo()
        {
            TblLibraryProcurementContract = new HashSet<TblLibraryProcurementContract>();
        }

        public long PkLibraryprocurementcontractrevisioninfoid { get; set; }
        public long FkLibraryactiveprocurementcontractid { get; set; }
        public long FkRevisioninfoid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblLibraryActiveProcurementContract FkLibraryactiveprocurementcontract { get; set; }
        public TblRevisionInfo FkRevisioninfo { get; set; }
        public ICollection<TblLibraryProcurementContract> TblLibraryProcurementContract { get; set; }
    }
}
