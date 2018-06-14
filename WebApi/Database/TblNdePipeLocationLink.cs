using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblNdePipeLocationLink
    {
        public long PkNdepipelocationlinkid { get; set; }
        public long FkMaterialpipespecid { get; set; }
        public long FkNdeclassid { get; set; }
        public int Percentage { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Locationenumvalue { get; set; }

        public TblMaterialPipeSpec FkMaterialpipespec { get; set; }
        public TblNdeClass FkNdeclass { get; set; }
    }
}
