using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDeadline
    {
        public long PkDeadlineid { get; set; }
        public long FkProjectid { get; set; }
        public string Deadlinename { get; set; }
        public DateTime Deadlinedate { get; set; }
        public int Deadlinecolor { get; set; }
        public bool Usedbyrs { get; set; }
        public bool Usedbypi { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProject FkProject { get; set; }
    }
}
