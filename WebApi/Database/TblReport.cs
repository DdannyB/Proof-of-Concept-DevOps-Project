using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblReport
    {
        public TblReport()
        {
            TblReportItemPart = new HashSet<TblReportItemPart>();
        }

        public long PkReportid { get; set; }
        public int Reportnumber { get; set; }
        public int Reportstate { get; set; }
        public DateTime? Reportissuedate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkBasereportid { get; set; }
        public int? Issuecount { get; set; }
        public string Reportjobdescription { get; set; }
        public string Reportjobmemo { get; set; }

        public TblBaseReport FkBasereport { get; set; }
        public ICollection<TblReportItemPart> TblReportItemPart { get; set; }
    }
}
