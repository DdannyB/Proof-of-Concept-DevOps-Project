using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryProcurementContractPricelist
    {
        public TblLibraryProcurementContractPricelist()
        {
            TblScopeJobDetailResourceEstimate = new HashSet<TblScopeJobDetailResourceEstimate>();
        }

        public long PkLibraryprocurementcontractpricelistid { get; set; }
        public long FkLibraryprocurementcontractid { get; set; }
        public long FkResourceid { get; set; }
        public long? FkPricelistrateunitofmeasurementid { get; set; }
        public int Pricelistsortorder { get; set; }
        public string Pricelistdescription { get; set; }
        public decimal Pricelistrate { get; set; }
        public string Pricelistnotes { get; set; }
        public string Pricelistrowtype { get; set; }
        public decimal? Pricelistcorrectionfactor { get; set; }
        public string Inactivecomputer { get; set; }
        public string Inactiveuser { get; set; }
        public DateTime? Inactivedate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public Guid Pricelistidentifier { get; set; }

        public TblLibraryProcurementContract FkLibraryprocurementcontract { get; set; }
        public TblUnitOfMeasurement FkPricelistrateunitofmeasurement { get; set; }
        public TblResource FkResource { get; set; }
        public ICollection<TblScopeJobDetailResourceEstimate> TblScopeJobDetailResourceEstimate { get; set; }
    }
}
