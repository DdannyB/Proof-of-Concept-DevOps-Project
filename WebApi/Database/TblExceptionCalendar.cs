using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblExceptionCalendar
    {
        public long PkExceptioncalendarid { get; set; }
        public long FkExceptionid { get; set; }
        public long FkCalendarid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblCalendar FkCalendar { get; set; }
        public TblException FkException { get; set; }
    }
}
