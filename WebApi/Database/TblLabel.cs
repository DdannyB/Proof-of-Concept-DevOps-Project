using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLabel
    {
        public TblLabel()
        {
            TblChangeRequestLabel = new HashSet<TblChangeRequestLabel>();
            TblScopeLabel = new HashSet<TblScopeLabel>();
        }

        public long PkLabelid { get; set; }
        public string Labeldescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkApplicationid { get; set; }
        public long? FkProjectid { get; set; }

        public TblApplication FkApplication { get; set; }
        public TblProject FkProject { get; set; }
        public ICollection<TblChangeRequestLabel> TblChangeRequestLabel { get; set; }
        public ICollection<TblScopeLabel> TblScopeLabel { get; set; }
    }
}
