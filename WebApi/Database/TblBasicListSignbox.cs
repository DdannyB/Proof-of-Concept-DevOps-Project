using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBasicListSignbox
    {
        public TblBasicListSignbox()
        {
            TblQaqcBasicListSignBox = new HashSet<TblQaqcBasicListSignBox>();
        }

        public long PkBasiclistsignboxid { get; set; }
        public long FkProjectid { get; set; }
        public string Name { get; set; }
        public int Sortorder { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProject FkProject { get; set; }
        public ICollection<TblQaqcBasicListSignBox> TblQaqcBasicListSignBox { get; set; }
    }
}
