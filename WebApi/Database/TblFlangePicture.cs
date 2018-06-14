using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblFlangePicture
    {
        public long PkFlangepictureid { get; set; }
        public long FkFlangetypeid { get; set; }
        public long? FkFlangesubtypeid { get; set; }
        public long? FkTorqtypeid { get; set; }
        public byte[] Flangeimage { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkTemplateblindpointid { get; set; }

        public TblFlangeSubType FkFlangesubtype { get; set; }
        public TblFlangeType FkFlangetype { get; set; }
        public TblTemplateBlindPoint FkTemplateblindpoint { get; set; }
        public TblTorqType FkTorqtype { get; set; }
    }
}
