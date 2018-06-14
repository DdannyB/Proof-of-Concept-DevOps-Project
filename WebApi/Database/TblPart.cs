using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPart
    {
        public TblPart()
        {
            TblWeldConnectionPart = new HashSet<TblWeldConnectionPart>();
        }

        public long PkPartid { get; set; }
        public long? FkPipetypeid { get; set; }
        public long? FkDiaid { get; set; }
        public long? FkDnid { get; set; }
        public long? FkLbsid { get; set; }
        public long? FkPnid { get; set; }
        public long? FkScheduleid { get; set; }
        public long? FkMateriallibraryid { get; set; }
        public long? FkCertificateid { get; set; }
        public long? FkThicknessid { get; set; }
        public long? FkBasematerialid { get; set; }
        public string Spool { get; set; }
        public decimal? Pipelengthdin { get; set; }
        public decimal? Pipelengthansi { get; set; }
        public long? Materiallibraryqty { get; set; }
        public long? Certificateqty { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Partalphanumericnr { get; set; }
        public bool Isexisting { get; set; }

        public TblBaseMaterial FkBasematerial { get; set; }
        public TblCertificate FkCertificate { get; set; }
        public TblDia FkDia { get; set; }
        public TblDn FkDn { get; set; }
        public TblLbs FkLbs { get; set; }
        public TblMaterialLibrary FkMateriallibrary { get; set; }
        public TblPipeType FkPipetype { get; set; }
        public TblPn FkPn { get; set; }
        public TblSchedule FkSchedule { get; set; }
        public TblThickness FkThickness { get; set; }
        public ICollection<TblWeldConnectionPart> TblWeldConnectionPart { get; set; }
    }
}
