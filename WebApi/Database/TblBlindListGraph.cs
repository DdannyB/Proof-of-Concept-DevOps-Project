using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindListGraph
    {
        public long PkBlindlistgraphid { get; set; }
        public long DkBlindlistid { get; set; }
        public long FkTemplateblindpointgraphid { get; set; }

        public TblTemplateBlindPointGraph FkTemplateblindpointgraph { get; set; }
    }
}
