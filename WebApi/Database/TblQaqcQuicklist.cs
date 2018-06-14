using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblQaqcQuicklist
    {
        public TblQaqcQuicklist()
        {
            TblQaqcBasicListSignBox = new HashSet<TblQaqcBasicListSignBox>();
            TblScopeQaqcQuicklist = new HashSet<TblScopeQaqcQuicklist>();
            TblShortcodeQaqcQuicklist = new HashSet<TblShortcodeQaqcQuicklist>();
        }

        public long PkQaqcquicklistid { get; set; }
        public long FkSubdisciplineid { get; set; }
        public long FkMainphaseid { get; set; }
        public long FkSubphaseid { get; set; }
        public long? FkHandovergroupmainid { get; set; }
        public long FkProjectid { get; set; }
        public string Listnr { get; set; }
        public string QaqcquicklistdescriptionL1 { get; set; }
        public string QaqcquicklistdescriptionL2 { get; set; }
        public string QaqcquicklistdescriptionL3 { get; set; }
        public string QaqcquicklistdescriptionL4 { get; set; }
        public string QaqcquicklistdescriptionL5 { get; set; }
        public byte[] Documentimage { get; set; }
        public string Documentname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkUserreportid { get; set; }

        public TblHandoverGroupMain FkHandovergroupmain { get; set; }
        public TblMainPhase FkMainphase { get; set; }
        public TblProject FkProject { get; set; }
        public TblSubDiscipline FkSubdiscipline { get; set; }
        public TblSubPhase FkSubphase { get; set; }
        public TblUserReport FkUserreport { get; set; }
        public ICollection<TblQaqcBasicListSignBox> TblQaqcBasicListSignBox { get; set; }
        public ICollection<TblScopeQaqcQuicklist> TblScopeQaqcQuicklist { get; set; }
        public ICollection<TblShortcodeQaqcQuicklist> TblShortcodeQaqcQuicklist { get; set; }
    }
}
