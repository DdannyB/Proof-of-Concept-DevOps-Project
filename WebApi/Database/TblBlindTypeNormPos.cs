using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindTypeNormPos
    {
        public TblBlindTypeNormPos()
        {
            TblBlindTypeNormPosActivity = new HashSet<TblBlindTypeNormPosActivity>();
            TblBlindTypeNormPosActivityNormbase = new HashSet<TblBlindTypeNormPosActivityNormbase>();
            TblBlindTypeNormPosActivityTemplate = new HashSet<TblBlindTypeNormPosActivityTemplate>();
        }

        public long PkBlindtypenormposid { get; set; }
        public long FkBlindtypeid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Normpostype { get; set; }

        public TblBlindType FkBlindtype { get; set; }
        public ICollection<TblBlindTypeNormPosActivity> TblBlindTypeNormPosActivity { get; set; }
        public ICollection<TblBlindTypeNormPosActivityNormbase> TblBlindTypeNormPosActivityNormbase { get; set; }
        public ICollection<TblBlindTypeNormPosActivityTemplate> TblBlindTypeNormPosActivityTemplate { get; set; }
    }
}
