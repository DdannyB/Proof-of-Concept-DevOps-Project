using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblFlangeSubType
    {
        public TblFlangeSubType()
        {
            TblBolting = new HashSet<TblBolting>();
            TblFlangePicture = new HashSet<TblFlangePicture>();
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
        }

        public long PkFlangesubtypeid { get; set; }
        public long FkFlangetypeid { get; set; }
        public string Flangesubtypecode { get; set; }
        public string Flangesubtypedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblFlangeType FkFlangetype { get; set; }
        public ICollection<TblBolting> TblBolting { get; set; }
        public ICollection<TblFlangePicture> TblFlangePicture { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPoint { get; set; }
    }
}
