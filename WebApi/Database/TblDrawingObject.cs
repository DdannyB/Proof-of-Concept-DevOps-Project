using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDrawingObject
    {
        public TblDrawingObject()
        {
            InverseFkFromdrawingobject = new HashSet<TblDrawingObject>();
            InverseFkTodrawingobject = new HashSet<TblDrawingObject>();
            TblDrawingObjectPosition = new HashSet<TblDrawingObjectPosition>();
        }

        public long PkDrawingobjectid { get; set; }
        public long Enmdrawingobjecttype { get; set; }
        public long FkDrawingid { get; set; }
        public long? FkFromdrawingobjectid { get; set; }
        public long? FkTodrawingobjectid { get; set; }
        public long? DkForeignkey { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public int? Bordercolor { get; set; }
        public int? Fillcolor { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDrawing FkDrawing { get; set; }
        public TblDrawingObject FkFromdrawingobject { get; set; }
        public TblDrawingObject FkTodrawingobject { get; set; }
        public ICollection<TblDrawingObject> InverseFkFromdrawingobject { get; set; }
        public ICollection<TblDrawingObject> InverseFkTodrawingobject { get; set; }
        public ICollection<TblDrawingObjectPosition> TblDrawingObjectPosition { get; set; }
    }
}
