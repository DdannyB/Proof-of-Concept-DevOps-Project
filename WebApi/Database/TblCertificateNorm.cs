using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCertificateNorm
    {
        public TblCertificateNorm()
        {
            TblCertificateCertificateNorm = new HashSet<TblCertificateCertificateNorm>();
        }

        public long PkCertificatenormid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblCertificateCertificateNorm> TblCertificateCertificateNorm { get; set; }
    }
}
