using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWorkpermit
    {
        public TblWorkpermit()
        {
            TblScopeJob = new HashSet<TblScopeJob>();
        }

        public long PkWorkpermitid { get; set; }
        public long FkScopeid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Permitnumber { get; set; }
        public string Permitdescription { get; set; }
        public string Action { get; set; }
        public string Reason { get; set; }
        public string Thirdpartynumber { get; set; }
        public string Thirdpartystatus { get; set; }
        public string Thirdpartymessage { get; set; }
        public DateTime? Thirdpartysyncdate { get; set; }

        public TblScope FkScope { get; set; }
        public ICollection<TblScopeJob> TblScopeJob { get; set; }
    }
}
