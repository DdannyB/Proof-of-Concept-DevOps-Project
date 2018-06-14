using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScheduleChangeProject
    {
        public TblScheduleChangeProject()
        {
            TblScheduleChange = new HashSet<TblScheduleChange>();
        }

        public long PkSchedulechangeprojectid { get; set; }
        public long FkProjectid { get; set; }
        public string Propertyname { get; set; }
        public int Entitytype { get; set; }
        public bool Selected { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProject FkProject { get; set; }
        public ICollection<TblScheduleChange> TblScheduleChange { get; set; }
    }
}
