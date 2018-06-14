using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeJobDetailResourceEstimate
    {
        public TblScopeJobDetailResourceEstimate()
        {
            TblScopeJobDetailResourceEstimateCorrectionfactor = new HashSet<TblScopeJobDetailResourceEstimateCorrectionfactor>();
        }

        public long PkScopejobdetailresourceestimateid { get; set; }
        public long FkScopejobdetailresourceid { get; set; }
        public long FkLibraryprocurementcontractpricelistid { get; set; }
        public long? FkPropackexportresourceid { get; set; }
        public long? FkNormbaseid { get; set; }
        public string Rowtype { get; set; }
        public decimal? Estimatehours { get; set; }
        public decimal? Quantity { get; set; }
        public string Requestorname { get; set; }
        public DateTime Requestordate { get; set; }
        public string Estimatememo { get; set; }
        public string Status { get; set; }
        public string Usertag { get; set; }
        public decimal? Fixedprice { get; set; }
        public string Drawingnumber { get; set; }
        public string Dimension { get; set; }
        public decimal? Plannedduration { get; set; }
        public decimal? M2 { get; set; }
        public decimal? M3 { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public int? Extrafloor { get; set; }
        public decimal? Dia { get; set; }
        public string Wizardguid { get; set; }
        public int? Wizardrownumber { get; set; }
        public string Scaffoldtype { get; set; }
        public string Blindtype { get; set; }
        public string Scaffoldtag { get; set; }
        public int? Estimatesortorder { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblLibraryProcurementContractPricelist FkLibraryprocurementcontractpricelist { get; set; }
        public TblNormbase FkNormbase { get; set; }
        public TblPropackExportResource FkPropackexportresource { get; set; }
        public TblScopeJobDetailResource FkScopejobdetailresource { get; set; }
        public ICollection<TblScopeJobDetailResourceEstimateCorrectionfactor> TblScopeJobDetailResourceEstimateCorrectionfactor { get; set; }
    }
}
