using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindTypeNormPosActivityTemplateMaterial
    {
        public long PkBlindtypenormposactivitytemplatematerialid { get; set; }
        public long FkBlindtypenormposactivitytemplateid { get; set; }
        public long FkSubmaterialgroupid { get; set; }
        public int Qty { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBlindTypeNormPosActivityTemplate FkBlindtypenormposactivitytemplate { get; set; }
        public TblSubMaterialGroup FkSubmaterialgroup { get; set; }
    }
}
