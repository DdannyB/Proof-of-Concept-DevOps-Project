using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLabels
    {
        public TblLabels()
        {
            TblBlindList = new HashSet<TblBlindList>();
        }

        public long PkLabelsid { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblBlindList> TblBlindList { get; set; }
    }
}
