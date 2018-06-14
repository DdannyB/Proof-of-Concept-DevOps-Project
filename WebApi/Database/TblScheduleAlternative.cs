using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScheduleAlternative
    {
        public long PkSchedulealternativeid { get; set; }
        public long FkScheduleid { get; set; }
        public string Schedulealternativedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblSchedule FkSchedule { get; set; }
    }
}
