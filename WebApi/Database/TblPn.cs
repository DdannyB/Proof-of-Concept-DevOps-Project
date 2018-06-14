using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPn
    {
        public TblPn()
        {
            TblBlindPointActivity = new HashSet<TblBlindPointActivity>();
            TblBolting = new HashSet<TblBolting>();
            TblCertificate = new HashSet<TblCertificate>();
            TblMaterialLibrary = new HashSet<TblMaterialLibrary>();
            TblMaterialPipeSpec = new HashSet<TblMaterialPipeSpec>();
            TblNormbase = new HashSet<TblNormbase>();
            TblPart = new HashSet<TblPart>();
            TblPnAlternative = new HashSet<TblPnAlternative>();
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointActivity = new HashSet<TblTemplateBlindPointActivity>();
            TblWeldConnectionPart = new HashSet<TblWeldConnectionPart>();
        }

        public long PkPnid { get; set; }
        public string Pndescription { get; set; }
        public decimal? Pnvalue { get; set; }
        public bool Iscustom { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblBlindPointActivity> TblBlindPointActivity { get; set; }
        public ICollection<TblBolting> TblBolting { get; set; }
        public ICollection<TblCertificate> TblCertificate { get; set; }
        public ICollection<TblMaterialLibrary> TblMaterialLibrary { get; set; }
        public ICollection<TblMaterialPipeSpec> TblMaterialPipeSpec { get; set; }
        public ICollection<TblNormbase> TblNormbase { get; set; }
        public ICollection<TblPart> TblPart { get; set; }
        public ICollection<TblPnAlternative> TblPnAlternative { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPoint { get; set; }
        public ICollection<TblTemplateBlindPointActivity> TblTemplateBlindPointActivity { get; set; }
        public ICollection<TblWeldConnectionPart> TblWeldConnectionPart { get; set; }
    }
}
