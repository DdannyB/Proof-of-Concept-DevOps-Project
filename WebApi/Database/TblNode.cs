using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblNode
    {
        public TblNode()
        {
            TblEdgeFkIncomingnode = new HashSet<TblEdge>();
            TblEdgeFkOutgoingnode = new HashSet<TblEdge>();
        }

        public long PkNodeid { get; set; }
        public long? DkBlindpointactivityid { get; set; }
        public long? DkBlindprojectmainphasesubphasereleasefinishid { get; set; }
        public string Phasegrouping { get; set; }

        public ICollection<TblEdge> TblEdgeFkIncomingnode { get; set; }
        public ICollection<TblEdge> TblEdgeFkOutgoingnode { get; set; }
    }
}
