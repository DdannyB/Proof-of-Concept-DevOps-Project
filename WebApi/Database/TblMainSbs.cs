using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMainSbs
    {
        public TblMainSbs()
        {
            TblSubSbs = new HashSet<TblSubSbs>();
        }

        public long PkMainsbsid { get; set; }
        public long FkProcessareaid { get; set; }
        public string Mainsbscode { get; set; }
        public string Mainsbsdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProcessarea FkProcessarea { get; set; }
        public ICollection<TblSubSbs> TblSubSbs { get; set; }
    }
}
