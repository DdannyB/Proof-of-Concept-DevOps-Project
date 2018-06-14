using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblGridSummary
    {
        public long PkGridsummaryid { get; set; }
        public long FkGridviewinfoid { get; set; }
        public string Fieldname { get; set; }
        public int Summarylocation { get; set; }
        public int Summarytype { get; set; }
        public int? Sortorder { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Displayformat { get; set; }

        public TblGridViewinfo FkGridviewinfo { get; set; }
    }
}
