using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDrawingObjectPosition
    {
        public long PkDrawingobjectpositionid { get; set; }
        public long FkDrawingobjectid { get; set; }
        public long Posx { get; set; }
        public long Posy { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDrawingObject FkDrawingobject { get; set; }
    }
}
