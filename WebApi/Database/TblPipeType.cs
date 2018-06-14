using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPipeType
    {
        public TblPipeType()
        {
            TblCertificate = new HashSet<TblCertificate>();
            TblMaterialLibrary = new HashSet<TblMaterialLibrary>();
            TblPart = new HashSet<TblPart>();
            TblWeldConnectionPart = new HashSet<TblWeldConnectionPart>();
        }

        public long PkPipetypeid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblCertificate> TblCertificate { get; set; }
        public ICollection<TblMaterialLibrary> TblMaterialLibrary { get; set; }
        public ICollection<TblPart> TblPart { get; set; }
        public ICollection<TblWeldConnectionPart> TblWeldConnectionPart { get; set; }
    }
}
