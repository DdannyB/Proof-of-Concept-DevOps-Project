using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPidRevisionPipeLine
    {
        public long PkPidrevisionpipelineid { get; set; }
        public long FkPipelineid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkPidrevisionid { get; set; }

        public TblPidRevision FkPidrevision { get; set; }
        public TblPipeline FkPipeline { get; set; }
    }
}
