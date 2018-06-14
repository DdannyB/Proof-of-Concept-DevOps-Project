using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblAudit
    {
        public TblAudit()
        {
            TblChangeRequest = new HashSet<TblChangeRequest>();
        }

        public long PkAuditid { get; set; }
        public long FkActivechangerequestid { get; set; }
        public bool Isactive { get; set; }
        public DateTime Versiondate { get; set; }
        public int Versionnumber { get; set; }
        public string Versiondescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblActiveChangeRequest FkActivechangerequest { get; set; }
        public ICollection<TblChangeRequest> TblChangeRequest { get; set; }
    }
}
