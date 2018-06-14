using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblJobDetail
    {
        public TblJobDetail()
        {
            TblJobDetailResource = new HashSet<TblJobDetailResource>();
            TblScopeJobDetail = new HashSet<TblScopeJobDetail>();
        }

        public long PkJobdetailid { get; set; }
        public long FkJobid { get; set; }
        public long FkJobdetaildataid { get; set; }
        public int? Jobdetailsortorder { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblJob FkJob { get; set; }
        public TblJobDetailData FkJobdetaildata { get; set; }
        public ICollection<TblJobDetailResource> TblJobDetailResource { get; set; }
        public ICollection<TblScopeJobDetail> TblScopeJobDetail { get; set; }
    }
}
