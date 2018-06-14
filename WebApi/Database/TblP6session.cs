using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblP6session
    {
        public TblP6session()
        {
            TblP6sessionHeartbeat = new HashSet<TblP6sessionHeartbeat>();
            TblP6sessionLog = new HashSet<TblP6sessionLog>();
            TblP6sessionMilestone = new HashSet<TblP6sessionMilestone>();
            TblP6sessionPlancard = new HashSet<TblP6sessionPlancard>();
            TblP6sessionRelation = new HashSet<TblP6sessionRelation>();
        }

        public long PkP6sessionid { get; set; }
        public long FkProjectid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Sessionguid { get; set; }

        public TblProject FkProject { get; set; }
        public ICollection<TblP6sessionHeartbeat> TblP6sessionHeartbeat { get; set; }
        public ICollection<TblP6sessionLog> TblP6sessionLog { get; set; }
        public ICollection<TblP6sessionMilestone> TblP6sessionMilestone { get; set; }
        public ICollection<TblP6sessionPlancard> TblP6sessionPlancard { get; set; }
        public ICollection<TblP6sessionRelation> TblP6sessionRelation { get; set; }
    }
}
