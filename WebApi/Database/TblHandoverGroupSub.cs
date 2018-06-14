using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblHandoverGroupSub
    {
        public TblHandoverGroupSub()
        {
            TblScopeHoGroupSub = new HashSet<TblScopeHoGroupSub>();
            TblShortcodeHoGroupSub = new HashSet<TblShortcodeHoGroupSub>();
        }

        public long PkHandovergroupsubid { get; set; }
        public long FkHandovergroupmainid { get; set; }
        public string Handoversubcode { get; set; }
        public string HandoversubdescriptionL1 { get; set; }
        public string HandoversubdescriptionL2 { get; set; }
        public string HandoversubdescriptionL3 { get; set; }
        public string HandoversubdescriptionL4 { get; set; }
        public string HandoversubdescriptionL5 { get; set; }
        public decimal? Hrs { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkResourceid { get; set; }

        public TblHandoverGroupMain FkHandovergroupmain { get; set; }
        public TblResource FkResource { get; set; }
        public ICollection<TblScopeHoGroupSub> TblScopeHoGroupSub { get; set; }
        public ICollection<TblShortcodeHoGroupSub> TblShortcodeHoGroupSub { get; set; }
    }
}
