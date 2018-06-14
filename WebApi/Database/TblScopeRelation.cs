using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeRelation
    {
        public TblScopeRelation()
        {
            TblScopeRelationPosition = new HashSet<TblScopeRelationPosition>();
        }

        public long PkScoperelationid { get; set; }
        public long? FkScopejobid1 { get; set; }
        public long? FkScopejobid2 { get; set; }
        public long? FkMilestoneid1 { get; set; }
        public long? FkMilestoneid2 { get; set; }
        public string Relationtype { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Relationlag { get; set; }
        public int? Gcrecord { get; set; }

        public TblMilestone FkMilestoneid1Navigation { get; set; }
        public TblMilestone FkMilestoneid2Navigation { get; set; }
        public TblScopeJob FkScopejobid1Navigation { get; set; }
        public TblScopeJob FkScopejobid2Navigation { get; set; }
        public ICollection<TblScopeRelationPosition> TblScopeRelationPosition { get; set; }
    }
}
