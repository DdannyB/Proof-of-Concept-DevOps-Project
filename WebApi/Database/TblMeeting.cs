using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMeeting
    {
        public TblMeeting()
        {
            TblAction = new HashSet<TblAction>();
            TblDecision = new HashSet<TblDecision>();
        }

        public long PkMeetingid { get; set; }
        public string Meetingdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblAction> TblAction { get; set; }
        public ICollection<TblDecision> TblDecision { get; set; }
    }
}
