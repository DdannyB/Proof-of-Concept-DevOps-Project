using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCalendar
    {
        public TblCalendar()
        {
            InverseFkParentcalendar = new HashSet<TblCalendar>();
            TblContractor = new HashSet<TblContractor>();
            TblExceptionCalendar = new HashSet<TblExceptionCalendar>();
            TblJobData = new HashSet<TblJobData>();
            TblMilestone = new HashSet<TblMilestone>();
            TblMilestoneTarget = new HashSet<TblMilestoneTarget>();
            TblProject = new HashSet<TblProject>();
            TblScopeJobTarget = new HashSet<TblScopeJobTarget>();
            TblSubProject = new HashSet<TblSubProject>();
        }

        public long PkCalendarid { get; set; }
        public long? FkParentcalendarid { get; set; }
        public string Calendarcode { get; set; }
        public string Calendardescription { get; set; }
        public string Calendarworkhours { get; set; }
        public int Calendartype { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long CompPkifcalendarcodeisnull { get; set; }

        public TblCalendar FkParentcalendar { get; set; }
        public ICollection<TblCalendar> InverseFkParentcalendar { get; set; }
        public ICollection<TblContractor> TblContractor { get; set; }
        public ICollection<TblExceptionCalendar> TblExceptionCalendar { get; set; }
        public ICollection<TblJobData> TblJobData { get; set; }
        public ICollection<TblMilestone> TblMilestone { get; set; }
        public ICollection<TblMilestoneTarget> TblMilestoneTarget { get; set; }
        public ICollection<TblProject> TblProject { get; set; }
        public ICollection<TblScopeJobTarget> TblScopeJobTarget { get; set; }
        public ICollection<TblSubProject> TblSubProject { get; set; }
    }
}
