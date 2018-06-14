using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblJobDetailResource
    {
        public TblJobDetailResource()
        {
            TblJobDetailResourceSmartCalculation = new HashSet<TblJobDetailResourceSmartCalculation>();
            TblScopeJobDetailResource = new HashSet<TblScopeJobDetailResource>();
        }

        public long PkJobdetailresourceid { get; set; }
        public long FkJobdetailresourcedataid { get; set; }
        public long FkJobdetailid { get; set; }
        public long FkResourceid { get; set; }
        public long? FkLibraryprocurementcontractid { get; set; }
        public int? Jobdetailresourcesortorder { get; set; }
        public decimal? Jobdetailresourcehours { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblJobDetail FkJobdetail { get; set; }
        public TblJobDetailResourceData FkJobdetailresourcedata { get; set; }
        public TblLibraryProcurementContract FkLibraryprocurementcontract { get; set; }
        public TblResource FkResource { get; set; }
        public ICollection<TblJobDetailResourceSmartCalculation> TblJobDetailResourceSmartCalculation { get; set; }
        public ICollection<TblScopeJobDetailResource> TblScopeJobDetailResource { get; set; }
    }
}
