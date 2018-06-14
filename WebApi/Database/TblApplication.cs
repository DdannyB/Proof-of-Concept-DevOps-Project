using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblApplication
    {
        public TblApplication()
        {
            TblApplicationRiskMatrix = new HashSet<TblApplicationRiskMatrix>();
            TblEffect = new HashSet<TblEffect>();
            TblLabel = new HashSet<TblLabel>();
            TblProbability = new HashSet<TblProbability>();
            TblRevision = new HashSet<TblRevision>();
            TblRightFunction = new HashSet<TblRightFunction>();
            TblRightGroup = new HashSet<TblRightGroup>();
            TblRiskMatrix = new HashSet<TblRiskMatrix>();
            TblRole = new HashSet<TblRole>();
            TblUser = new HashSet<TblUser>();
            TblUserApplicationProject = new HashSet<TblUserApplicationProject>();
            TblUserLogin = new HashSet<TblUserLogin>();
            TblWorkflow = new HashSet<TblWorkflow>();
        }

        public long PkApplicationid { get; set; }
        public int Enumvalue { get; set; }
        public string Name { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int? Sortorder { get; set; }

        public ICollection<TblApplicationRiskMatrix> TblApplicationRiskMatrix { get; set; }
        public ICollection<TblEffect> TblEffect { get; set; }
        public ICollection<TblLabel> TblLabel { get; set; }
        public ICollection<TblProbability> TblProbability { get; set; }
        public ICollection<TblRevision> TblRevision { get; set; }
        public ICollection<TblRightFunction> TblRightFunction { get; set; }
        public ICollection<TblRightGroup> TblRightGroup { get; set; }
        public ICollection<TblRiskMatrix> TblRiskMatrix { get; set; }
        public ICollection<TblRole> TblRole { get; set; }
        public ICollection<TblUser> TblUser { get; set; }
        public ICollection<TblUserApplicationProject> TblUserApplicationProject { get; set; }
        public ICollection<TblUserLogin> TblUserLogin { get; set; }
        public ICollection<TblWorkflow> TblWorkflow { get; set; }
    }
}
