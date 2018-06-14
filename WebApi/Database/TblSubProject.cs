using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSubProject
    {
        public TblSubProject()
        {
            TblScope = new HashSet<TblScope>();
            TblUserSetting = new HashSet<TblUserSetting>();
        }

        public long PkSubprojectid { get; set; }
        public string Subprojectname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkProjectid { get; set; }
        public long? FkCalendarid { get; set; }
        public DateTime? Subprojectearlystart { get; set; }
        public DateTime? Subprojectlatefinish { get; set; }
        public DateTime? Subprojectearlyfinish { get; set; }
        public DateTime? Subprojectlatestart { get; set; }
        public int Sortorder { get; set; }

        public TblCalendar FkCalendar { get; set; }
        public TblProject FkProject { get; set; }
        public ICollection<TblScope> TblScope { get; set; }
        public ICollection<TblUserSetting> TblUserSetting { get; set; }
    }
}
