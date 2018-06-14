using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPropackExportResource
    {
        public TblPropackExportResource()
        {
            TblScopeJobDetailResourceEstimate = new HashSet<TblScopeJobDetailResourceEstimate>();
        }

        public long PkPropackexportresourceid { get; set; }
        public long FkPropackexportid { get; set; }
        public long DkScopejobdetailresid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Lastscoperevision { get; set; }

        public TblPropackExport FkPropackexport { get; set; }
        public ICollection<TblScopeJobDetailResourceEstimate> TblScopeJobDetailResourceEstimate { get; set; }
    }
}
