using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindType
    {
        public TblBlindType()
        {
            TblActivityBlindtype = new HashSet<TblActivityBlindtype>();
            TblBlindListTypeBlindTypeQcType = new HashSet<TblBlindListTypeBlindTypeQcType>();
            TblBlindPoint = new HashSet<TblBlindPoint>();
            TblBlindPointActivity = new HashSet<TblBlindPointActivity>();
            TblBlindTypeNormPos = new HashSet<TblBlindTypeNormPos>();
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointActivity = new HashSet<TblTemplateBlindPointActivity>();
        }

        public long PkBlindtypeid { get; set; }
        public string Blindtypedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Blindtypecode { get; set; }
        public long? FkBlindtypesymbolid { get; set; }

        public TblBlindTypeSymbol FkBlindtypesymbol { get; set; }
        public ICollection<TblActivityBlindtype> TblActivityBlindtype { get; set; }
        public ICollection<TblBlindListTypeBlindTypeQcType> TblBlindListTypeBlindTypeQcType { get; set; }
        public ICollection<TblBlindPoint> TblBlindPoint { get; set; }
        public ICollection<TblBlindPointActivity> TblBlindPointActivity { get; set; }
        public ICollection<TblBlindTypeNormPos> TblBlindTypeNormPos { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPoint { get; set; }
        public ICollection<TblTemplateBlindPointActivity> TblTemplateBlindPointActivity { get; set; }
    }
}
