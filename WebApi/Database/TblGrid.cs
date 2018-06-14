using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblGrid
    {
        public TblGrid()
        {
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
        }

        public long PkGridid { get; set; }
        public string Gridcode { get; set; }
        public string Griddescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPoint { get; set; }
    }
}
