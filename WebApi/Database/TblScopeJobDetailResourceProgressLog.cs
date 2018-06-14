using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeJobDetailResourceProgressLog
    {
        public long PkScopejobdetailresourceprogresslogid { get; set; }
        public long DkScopejobdetailresourceid { get; set; }
        public DateTime? Resourceactualstartdate { get; set; }
        public DateTime? Resourceactualfinishdate { get; set; }
        public bool Resourceismanualactualtimeoverride { get; set; }
        public string Logaction { get; set; }
        public DateTime Logdate { get; set; }
        public int? Resourceprogress { get; set; }
        public string Resourceprogressmode { get; set; }
        public string Resourceprogressusername { get; set; }
        public string Resourcequalitycontrol { get; set; }
        public int? Resourcetype { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
    }
}
