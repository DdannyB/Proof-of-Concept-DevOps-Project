using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblQaqcReport
    {
        public TblQaqcReport()
        {
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
        }

        public long PkQaqcreportid { get; set; }
        public string Qaqcreportcode { get; set; }
        public string Qaqcreportdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPoint { get; set; }
    }
}
