using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLbs
    {
        public TblLbs()
        {
            TblBlindPointActivity = new HashSet<TblBlindPointActivity>();
            TblBolting = new HashSet<TblBolting>();
            TblCertificate = new HashSet<TblCertificate>();
            TblLbsAlternative = new HashSet<TblLbsAlternative>();
            TblMaterialLibrary = new HashSet<TblMaterialLibrary>();
            TblMaterialPipeSpec = new HashSet<TblMaterialPipeSpec>();
            TblNormbase = new HashSet<TblNormbase>();
            TblPart = new HashSet<TblPart>();
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointActivity = new HashSet<TblTemplateBlindPointActivity>();
            TblWeldConnectionPart = new HashSet<TblWeldConnectionPart>();
        }

        public long PkLbsid { get; set; }
        public string Lbsdescription { get; set; }
        public decimal? Lbsvalue { get; set; }
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
        public ICollection<TblLbsAlternative> TblLbsAlternative { get; set; }
        public ICollection<TblMaterialLibrary> TblMaterialLibrary { get; set; }
        public ICollection<TblMaterialPipeSpec> TblMaterialPipeSpec { get; set; }
        public ICollection<TblNormbase> TblNormbase { get; set; }
        public ICollection<TblPart> TblPart { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPoint { get; set; }
        public ICollection<TblTemplateBlindPointActivity> TblTemplateBlindPointActivity { get; set; }
        public ICollection<TblWeldConnectionPart> TblWeldConnectionPart { get; set; }
    }
}
