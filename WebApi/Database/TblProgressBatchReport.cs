using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblProgressBatchReport
    {
        public long PkProgressbatchreportid { get; set; }
        public long FkProgressbatchid { get; set; }
        public long? FkReportviewid { get; set; }
        public string Reportcode { get; set; }
        public int Sortorder { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProgressBatch FkProgressbatch { get; set; }
        public TblReportView FkReportview { get; set; }
    }
}
