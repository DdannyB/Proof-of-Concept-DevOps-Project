using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSceIcon
    {
        public long PkSceiconid { get; set; }
        public byte[] Sce16 { get; set; }
        public byte[] Sce32 { get; set; }
        public byte[] Sce128 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
    }
}
