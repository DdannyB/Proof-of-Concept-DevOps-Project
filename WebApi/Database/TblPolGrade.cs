using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPolGrade
    {
        public TblPolGrade()
        {
            TblCleanIndex = new HashSet<TblCleanIndex>();
        }

        public long PkPolgradeid { get; set; }
        public string Polgradedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblCleanIndex> TblCleanIndex { get; set; }
    }
}
