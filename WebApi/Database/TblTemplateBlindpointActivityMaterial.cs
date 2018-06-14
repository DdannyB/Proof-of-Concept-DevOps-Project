using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTemplateBlindpointActivityMaterial
    {
        public long PkTemplateblindpointactivitymaterialid { get; set; }
        public long FkTemplateblindpointactivityid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkMaterialid { get; set; }

        public TblMaterial FkMaterial { get; set; }
        public TblTemplateBlindPointActivity FkTemplateblindpointactivity { get; set; }
    }
}
