using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMilestoneTarget
    {
        public long PkMilestonetargetid { get; set; }
        public int? Progress { get; set; }
        public DateTime? Esdate { get; set; }
        public DateTime? Lsdate { get; set; }
        public DateTime? Psdate { get; set; }
        public DateTime? Asdate { get; set; }
        public DateTime? Afdate { get; set; }
        public long? FkCalendarid { get; set; }
        public long FkMilestoneid { get; set; }
        public long FkTargetid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int? Milestonetargetfreefloat { get; set; }
        public int? Milestonetargettotalfloat { get; set; }

        public TblCalendar FkCalendar { get; set; }
        public TblMilestone FkMilestone { get; set; }
        public TblTarget FkTarget { get; set; }
    }
}
