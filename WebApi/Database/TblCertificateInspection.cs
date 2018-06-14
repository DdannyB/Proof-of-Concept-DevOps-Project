using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCertificateInspection
    {
        public long PkCertificateinspectionid { get; set; }
        public long FkInspectorid { get; set; }
        public long FkCertificateid { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblCertificate FkCertificate { get; set; }
        public TblUser FkInspector { get; set; }
    }
}
