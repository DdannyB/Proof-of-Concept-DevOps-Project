using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMaterialPipeSpec
    {
        public TblMaterialPipeSpec()
        {
            TblLisl = new HashSet<TblLisl>();
            TblMaterialPipeSpecLibrary = new HashSet<TblMaterialPipeSpecLibrary>();
            TblNdePipeLocationLink = new HashSet<TblNdePipeLocationLink>();
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
            TblWeldConnection = new HashSet<TblWeldConnection>();
            TblWeldProcedure = new HashSet<TblWeldProcedure>();
        }

        public long PkMaterialpipespecid { get; set; }
        public string Pipespeccode { get; set; }
        public string Pipespecdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkGaskettypeid { get; set; }
        public long? FkBolttypeid { get; set; }
        public long? FkDiaid { get; set; }
        public long? FkLbsid { get; set; }
        public long? FkDnid { get; set; }
        public long? FkPnid { get; set; }

        public TblBoltType FkBolttype { get; set; }
        public TblDia FkDia { get; set; }
        public TblDn FkDn { get; set; }
        public TblGasketType FkGaskettype { get; set; }
        public TblLbs FkLbs { get; set; }
        public TblPn FkPn { get; set; }
        public ICollection<TblLisl> TblLisl { get; set; }
        public ICollection<TblMaterialPipeSpecLibrary> TblMaterialPipeSpecLibrary { get; set; }
        public ICollection<TblNdePipeLocationLink> TblNdePipeLocationLink { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPoint { get; set; }
        public ICollection<TblWeldConnection> TblWeldConnection { get; set; }
        public ICollection<TblWeldProcedure> TblWeldProcedure { get; set; }
    }
}
