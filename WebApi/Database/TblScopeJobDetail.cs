using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeJobDetail
    {
        public TblScopeJobDetail()
        {
            TblScopeJobDetailResource = new HashSet<TblScopeJobDetailResource>();
            TblScopeJobDetailTarget = new HashSet<TblScopeJobDetailTarget>();
        }

        public long PkScopejobdetailid { get; set; }
        public long FkScopejobid { get; set; }
        public long? FkJobdetailid { get; set; }
        public long FkJobdetaildataid { get; set; }
        public int? Scopejobdetailsortorder { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblJobDetail FkJobdetail { get; set; }
        public TblJobDetailData FkJobdetaildata { get; set; }
        public TblScopeJob FkScopejob { get; set; }
        public ICollection<TblScopeJobDetailResource> TblScopeJobDetailResource { get; set; }
        public ICollection<TblScopeJobDetailTarget> TblScopeJobDetailTarget { get; set; }
    }
}
