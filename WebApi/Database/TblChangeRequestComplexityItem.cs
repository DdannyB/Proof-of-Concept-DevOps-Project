using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblChangeRequestComplexityItem
    {
        public long PkChangerequestcomplexityitemid { get; set; }
        public long FkActivechangerequestid { get; set; }
        public long FkComplexityitemid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblActiveChangeRequest FkActivechangerequest { get; set; }
        public TblComplexityItem FkComplexityitem { get; set; }
    }
}
