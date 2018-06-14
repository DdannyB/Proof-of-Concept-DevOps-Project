using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeRelationPosition
    {
        public long PkScoperelationpositionid { get; set; }
        public long? FkScopeid { get; set; }
        public long? FkScopejobid { get; set; }
        public long? FkScopemilestoneid { get; set; }
        public long? FkScoperelationid { get; set; }
        public int Scoperelationpositionx { get; set; }
        public int Scoperelationpositiony { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int? Gcrecord { get; set; }

        public TblScope FkScope { get; set; }
        public TblScopeJob FkScopejob { get; set; }
        public TblScopeMilestone1 FkScopemilestone { get; set; }
        public TblScopeRelation FkScoperelation { get; set; }
    }
}
