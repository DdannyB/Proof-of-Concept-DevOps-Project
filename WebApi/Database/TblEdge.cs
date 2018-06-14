using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblEdge
    {
        public long PkEdgeid { get; set; }
        public long FkTemplateblindpointgraphid { get; set; }
        public long FkIncomingnodeid { get; set; }
        public long FkOutgoingnodeid { get; set; }

        public TblNode FkIncomingnode { get; set; }
        public TblNode FkOutgoingnode { get; set; }
        public TblTemplateBlindPointGraph FkTemplateblindpointgraph { get; set; }
    }
}
