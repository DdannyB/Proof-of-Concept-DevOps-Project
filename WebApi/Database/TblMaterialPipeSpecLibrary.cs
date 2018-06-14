using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMaterialPipeSpecLibrary
    {
        public long PkMaterialpipespeclibraryid { get; set; }
        public long FkMateriallibraryid { get; set; }
        public long FkMaterialpipespecid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblMaterialLibrary FkMateriallibrary { get; set; }
        public TblMaterialPipeSpec FkMaterialpipespec { get; set; }
    }
}
