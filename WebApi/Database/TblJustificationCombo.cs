using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblJustificationCombo
    {
        public TblJustificationCombo()
        {
            TblScope = new HashSet<TblScope>();
        }

        public long PkJustificationcomboid { get; set; }
        public string Justificationshortcode { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblScope> TblScope { get; set; }
    }
}
