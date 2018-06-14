using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblJobDetailResourceData
    {
        public TblJobDetailResourceData()
        {
            TblJobDetailResource = new HashSet<TblJobDetailResource>();
            TblScopeJobDetailResource = new HashSet<TblScopeJobDetailResource>();
        }

        public long PkJobdetailresourcedataid { get; set; }
        public int Jobdetailresourcecrew { get; set; }
        public string Jobdetailresourcequalitycontrol { get; set; }
        public string Jobdetailresourcememo { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblJobDetailResource> TblJobDetailResource { get; set; }
        public ICollection<TblScopeJobDetailResource> TblScopeJobDetailResource { get; set; }
    }
}
