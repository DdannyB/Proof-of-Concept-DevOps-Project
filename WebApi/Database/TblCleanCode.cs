using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCleanCode
    {
        public TblCleanCode()
        {
            TblCleanIndex = new HashSet<TblCleanIndex>();
        }

        public long PkCleancodeid { get; set; }
        public string Cleancodedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblCleanIndex> TblCleanIndex { get; set; }
    }
}
