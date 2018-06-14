using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTimekeepingMileage
    {
        public long PkTimekeepingmileageid { get; set; }
        public long FkUserid { get; set; }
        public long FkProjectid { get; set; }
        public long FkTimekeepingmileagetypeid { get; set; }
        public DateTime? Registrationdate { get; set; }
        public decimal Distance { get; set; }
        public string Comment { get; set; }
        public bool Ischangedbytimeit { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProject FkProject { get; set; }
        public TblTimeKeepingMileageType FkTimekeepingmileagetype { get; set; }
        public TblUser FkUser { get; set; }
    }
}
