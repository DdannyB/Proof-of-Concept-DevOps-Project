using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindListTypeBlindTypeQcType
    {
        public long PkBlindlisttypeblindtypeqctypeid { get; set; }
        public long FkBlindlisttypeid { get; set; }
        public long FkBlindtypeid { get; set; }
        public int Activityqctype { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBlindListType FkBlindlisttype { get; set; }
        public TblBlindType FkBlindtype { get; set; }
    }
}
