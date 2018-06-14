using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTemplateBlindPointActivityCircumstance
    {
        public long PkTemplateblindpointactivitycircumstanceid { get; set; }
        public long FkTemplateblindpointactivityid { get; set; }
        public long FkCircumstanceid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblCircumstance FkCircumstance { get; set; }
        public TblTemplateBlindPointActivity FkTemplateblindpointactivity { get; set; }
    }
}
