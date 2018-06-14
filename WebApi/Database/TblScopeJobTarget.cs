using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeJobTarget
    {
        public TblScopeJobTarget()
        {
            TblScopeJobDetailResourceTarget = new HashSet<TblScopeJobDetailResourceTarget>();
        }

        public long PkScopejobtargetid { get; set; }
        public long FkScopejobid { get; set; }
        public long FkTargetid { get; set; }
        public long? FkCalendarid { get; set; }
        public DateTime? Scopejobtargetearlystartdate { get; set; }
        public DateTime? Scopejobtargetearlyfinishdate { get; set; }
        public DateTime? Scopejobtargetlatestartdate { get; set; }
        public DateTime? Scopejobtargetlatefinishdatedate { get; set; }
        public decimal? Scopejobtargetplannedduration { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public DateTime? Scopejobtargetplannedstartdate { get; set; }
        public DateTime? Scopejobtargetplannedfinishdate { get; set; }
        public int? Progress { get; set; }

        public TblCalendar FkCalendar { get; set; }
        public TblScopeJob FkScopejob { get; set; }
        public TblTarget FkTarget { get; set; }
        public ICollection<TblScopeJobDetailResourceTarget> TblScopeJobDetailResourceTarget { get; set; }
    }
}
