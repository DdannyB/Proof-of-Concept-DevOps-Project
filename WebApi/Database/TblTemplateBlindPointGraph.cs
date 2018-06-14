using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTemplateBlindPointGraph
    {
        public TblTemplateBlindPointGraph()
        {
            TblBlindListGraph = new HashSet<TblBlindListGraph>();
            TblEdge = new HashSet<TblEdge>();
        }

        public long PkTemplateblindpointgraphid { get; set; }
        public long DkTemplateblindpointid { get; set; }
        public DateTime? Lastmodified { get; set; }

        public ICollection<TblBlindListGraph> TblBlindListGraph { get; set; }
        public ICollection<TblEdge> TblEdge { get; set; }
    }
}
