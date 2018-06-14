using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblNdeClass
    {
        public TblNdeClass()
        {
            TblNdePipeLocationLink = new HashSet<TblNdePipeLocationLink>();
            TblWeldConnection = new HashSet<TblWeldConnection>();
        }

        public long PkNdeclassid { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblNdePipeLocationLink> TblNdePipeLocationLink { get; set; }
        public ICollection<TblWeldConnection> TblWeldConnection { get; set; }
    }
}
