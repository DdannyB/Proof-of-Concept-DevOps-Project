using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPolType
    {
        public TblPolType()
        {
            TblCleanIndex = new HashSet<TblCleanIndex>();
        }

        public long PkPoltypeid { get; set; }
        public string Poltypedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblCleanIndex> TblCleanIndex { get; set; }
    }
}
