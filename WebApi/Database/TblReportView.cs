using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblReportView
    {
        public TblReportView()
        {
            TblProgressBatchReport = new HashSet<TblProgressBatchReport>();
            TblReportViewParameter = new HashSet<TblReportViewParameter>();
        }

        public long PkReportviewid { get; set; }
        public string Reportcode { get; set; }
        public string Reportviewname { get; set; }
        public long? FkProjectid { get; set; }
        public long? FkUserid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProject FkProject { get; set; }
        public TblUser FkUser { get; set; }
        public ICollection<TblProgressBatchReport> TblProgressBatchReport { get; set; }
        public ICollection<TblReportViewParameter> TblReportViewParameter { get; set; }
    }
}
