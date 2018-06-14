using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPolDegree
    {
        public TblPolDegree()
        {
            TblCleanIndex = new HashSet<TblCleanIndex>();
        }

        public long PkPoldegreeid { get; set; }
        public string Poldegreedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblCleanIndex> TblCleanIndex { get; set; }
    }
}
