using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCertificateType
    {
        public TblCertificateType()
        {
            TblCertificate = new HashSet<TblCertificate>();
        }

        public long PkCertificatetypeid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Isdefault { get; set; }

        public ICollection<TblCertificate> TblCertificate { get; set; }
    }
}
