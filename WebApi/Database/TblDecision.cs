using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDecision
    {
        public long PkDecisionid { get; set; }
        public long FkScopeid { get; set; }
        public long FkMeetingid { get; set; }
        public long FkDecisionbyuserid { get; set; }
        public DateTime Meetingdate { get; set; }
        public string Decisiondescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblUser FkDecisionbyuser { get; set; }
        public TblMeeting FkMeeting { get; set; }
        public TblScope FkScope { get; set; }
    }
}
