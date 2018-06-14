using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblHandoverGroupMain
    {
        public TblHandoverGroupMain()
        {
            TblHandoverGroupSub = new HashSet<TblHandoverGroupSub>();
            TblQaqcQuicklist = new HashSet<TblQaqcQuicklist>();
        }

        public long PkHandovergroupmainid { get; set; }
        public long FkProjectid { get; set; }
        public string Handovermaincode { get; set; }
        public string HandovermaindescriptionL1 { get; set; }
        public string HandovermaindescriptionL2 { get; set; }
        public string HandovermaindescriptionL3 { get; set; }
        public string HandovermaindescriptionL4 { get; set; }
        public string HandovermaindescriptionL5 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProject FkProject { get; set; }
        public ICollection<TblHandoverGroupSub> TblHandoverGroupSub { get; set; }
        public ICollection<TblQaqcQuicklist> TblQaqcQuicklist { get; set; }
    }
}
