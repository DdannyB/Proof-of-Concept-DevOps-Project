using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblAction
    {
        public long PkActionid { get; set; }
        public long FkScopeid { get; set; }
        public long FkMeetingid { get; set; }
        public long FkActionbyuserid { get; set; }
        public long FkActionholderuserid { get; set; }
        public DateTime Meetingdate { get; set; }
        public string Actiondescription { get; set; }
        public DateTime Actionduedate { get; set; }
        public DateTime? Actionreadydate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblUser FkActionbyuser { get; set; }
        public TblUser FkActionholderuser { get; set; }
        public TblMeeting FkMeeting { get; set; }
        public TblScope FkScope { get; set; }
    }
}
