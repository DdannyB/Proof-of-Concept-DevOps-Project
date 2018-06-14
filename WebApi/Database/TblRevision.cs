using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblRevision
    {
        public TblRevision()
        {
            TblBlindListRevision = new HashSet<TblBlindListRevision>();
            TblRevisionChange = new HashSet<TblRevisionChange>();
            TblRevisionFeedback = new HashSet<TblRevisionFeedback>();
            TblScopeRequestRevision = new HashSet<TblScopeRequestRevision>();
        }

        public long PkRevisionid { get; set; }
        public string Revisionuser { get; set; }
        public int Revisionno { get; set; }
        public int Revisiontype { get; set; }
        public string Revisiondescription { get; set; }
        public DateTime Revisiondate { get; set; }
        public long FkApplicationid { get; set; }
        public DateTime? Revisionaccepteddate { get; set; }
        public string Revisionaccepteduser { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblApplication FkApplication { get; set; }
        public ICollection<TblBlindListRevision> TblBlindListRevision { get; set; }
        public ICollection<TblRevisionChange> TblRevisionChange { get; set; }
        public ICollection<TblRevisionFeedback> TblRevisionFeedback { get; set; }
        public ICollection<TblScopeRequestRevision> TblScopeRequestRevision { get; set; }
    }
}
