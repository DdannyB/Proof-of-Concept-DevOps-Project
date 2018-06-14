using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWeldConnection
    {
        public TblWeldConnection()
        {
            TblNdeRequest = new HashSet<TblNdeRequest>();
            TblWeldConnectionPart = new HashSet<TblWeldConnectionPart>();
            TblWeldConnectionWelder = new HashSet<TblWeldConnectionWelder>();
        }

        public long PkWeldconnectionid { get; set; }
        public string Weldconnectionautonr { get; set; }
        public string Weldconnectionnr { get; set; }
        public string Weldconnectionsubnr { get; set; }
        public long? FkLislid { get; set; }
        public long? FkConnectiontypeid { get; set; }
        public long? FkMaterialpipespecid { get; set; }
        public long? FkNdeclassid { get; set; }
        public long? FkWeldprocedureid { get; set; }
        public long? FkWeldprocedurespecificationid { get; set; }
        public long? FkWeldprocessid { get; set; }
        public DateTime? Readydate { get; set; }
        public long? FkReadyby { get; set; }
        public string Elevation { get; set; }
        public string Area { get; set; }
        public decimal? Lasinchesdin { get; set; }
        public bool Isprepwht { get; set; }
        public bool Ispostpwht { get; set; }
        public string Pwhtreportnr { get; set; }
        public DateTime? Pwhtreadydate { get; set; }
        public long? FkPwhtreadybyid { get; set; }
        public bool Isrepairconnection { get; set; }
        public int? Repairnr { get; set; }
        public bool Isrejectedconnection { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Remark { get; set; }
        public string Notes { get; set; }
        public int? Locationenumvalue { get; set; }
        public long? FkPipelineid { get; set; }
        public string Designcode { get; set; }
        public long? FkFillermaterialid { get; set; }

        public TblConnectionType FkConnectiontype { get; set; }
        public TblFillerMaterial FkFillermaterial { get; set; }
        public TblLisl FkLisl { get; set; }
        public TblMaterialPipeSpec FkMaterialpipespec { get; set; }
        public TblNdeClass FkNdeclass { get; set; }
        public TblPipeline FkPipeline { get; set; }
        public TblUser FkPwhtreadyby { get; set; }
        public TblUser FkReadybyNavigation { get; set; }
        public TblWeldProcedure FkWeldprocedure { get; set; }
        public TblWeldProcedureSpecification FkWeldprocedurespecification { get; set; }
        public TblWeldProcess FkWeldprocess { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequest { get; set; }
        public ICollection<TblWeldConnectionPart> TblWeldConnectionPart { get; set; }
        public ICollection<TblWeldConnectionWelder> TblWeldConnectionWelder { get; set; }
    }
}
