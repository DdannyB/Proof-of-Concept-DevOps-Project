using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindListType
    {
        public TblBlindListType()
        {
            TblBlindList = new HashSet<TblBlindList>();
            TblBlindListTypeBlindTypeQcType = new HashSet<TblBlindListTypeBlindTypeQcType>();
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
        }

        public long PkBlindlisttypeid { get; set; }
        public string Blindlisttypecode { get; set; }
        public string Blindlisttypedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Printname { get; set; }

        public ICollection<TblBlindList> TblBlindList { get; set; }
        public ICollection<TblBlindListTypeBlindTypeQcType> TblBlindListTypeBlindTypeQcType { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPoint { get; set; }
    }
}
