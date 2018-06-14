using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblFlangeType
    {
        public TblFlangeType()
        {
            TblBolting = new HashSet<TblBolting>();
            TblFlangePicture = new HashSet<TblFlangePicture>();
            TblFlangeSubType = new HashSet<TblFlangeSubType>();
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
        }

        public long PkFlangetypeid { get; set; }
        public string Flangetypecode { get; set; }
        public string Flangetypedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblBolting> TblBolting { get; set; }
        public ICollection<TblFlangePicture> TblFlangePicture { get; set; }
        public ICollection<TblFlangeSubType> TblFlangeSubType { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPoint { get; set; }
    }
}
