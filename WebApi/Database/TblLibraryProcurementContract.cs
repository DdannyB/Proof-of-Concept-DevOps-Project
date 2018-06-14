using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryProcurementContract
    {
        public TblLibraryProcurementContract()
        {
            TblJobDetailResource = new HashSet<TblJobDetailResource>();
            TblLibraryProcurementContractPricelist = new HashSet<TblLibraryProcurementContractPricelist>();
            TblLibraryProcurementContractProject = new HashSet<TblLibraryProcurementContractProject>();
        }

        public long PkLibraryprocurementcontractid { get; set; }
        public long? FkLibraryprocurementcontractrevisioninfoid { get; set; }
        public long? FkProcurementaccountcodeid { get; set; }
        public long? FkProcurementcodeid { get; set; }
        public long? FkUniquecheckprojectid { get; set; }
        public long FkSubdisciplineid { get; set; }
        public long FkContractorid { get; set; }
        public int Contractnumber { get; set; }
        public string Contractprefix { get; set; }
        public string Contractdescription { get; set; }
        public decimal Contractcorrectionfactor { get; set; }
        public bool Contractisprojectcustom { get; set; }
        public string Publishedcomputer { get; set; }
        public string Publisheduser { get; set; }
        public DateTime? Publisheddate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblContractor FkContractor { get; set; }
        public TblLibraryProcurementContractRevisionInfo FkLibraryprocurementcontractrevisioninfo { get; set; }
        public TblProcurementAccountcode FkProcurementaccountcode { get; set; }
        public TblProcurementCode FkProcurementcode { get; set; }
        public TblSubDiscipline FkSubdiscipline { get; set; }
        public TblProject FkUniquecheckproject { get; set; }
        public TblLibraryActiveProcurementContract TblLibraryActiveProcurementContract { get; set; }
        public ICollection<TblJobDetailResource> TblJobDetailResource { get; set; }
        public ICollection<TblLibraryProcurementContractPricelist> TblLibraryProcurementContractPricelist { get; set; }
        public ICollection<TblLibraryProcurementContractProject> TblLibraryProcurementContractProject { get; set; }
    }
}
