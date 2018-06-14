using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTemplateMilestone
    {
        public TblTemplateMilestone()
        {
            TblLibraryScopeTemplateMilestoneTemplate = new HashSet<TblLibraryScopeTemplateMilestoneTemplate>();
            TblMilestone = new HashSet<TblMilestone>();
            TblScopeMilestone = new HashSet<TblScopeMilestone>();
        }

        public long PkTemplatemilestoneid { get; set; }
        public long FkProjectid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Sortorder { get; set; }
        public string Milestonetype { get; set; }
        public string Milestonedescr { get; set; }
        public int Milestonecolor { get; set; }
        public int Startfinish { get; set; }

        public TblProject FkProject { get; set; }
        public ICollection<TblLibraryScopeTemplateMilestoneTemplate> TblLibraryScopeTemplateMilestoneTemplate { get; set; }
        public ICollection<TblMilestone> TblMilestone { get; set; }
        public ICollection<TblScopeMilestone> TblScopeMilestone { get; set; }
    }
}
