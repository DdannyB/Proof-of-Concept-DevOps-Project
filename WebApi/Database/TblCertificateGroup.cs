using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCertificateGroup
    {
        public TblCertificateGroup()
        {
            TblCertificate = new HashSet<TblCertificate>();
        }

        public long PkCertificategroupid { get; set; }
        public string Certificategroup { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Prefix { get; set; }
        public bool Iswelditgroup { get; set; }

        public ICollection<TblCertificate> TblCertificate { get; set; }
    }
}
