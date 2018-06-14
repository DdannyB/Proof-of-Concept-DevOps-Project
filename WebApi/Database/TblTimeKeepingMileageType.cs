using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTimeKeepingMileageType
    {
        public TblTimeKeepingMileageType()
        {
            TblTimekeepingMileage = new HashSet<TblTimekeepingMileage>();
        }

        public long PkTimekeepingmileagetypeid { get; set; }
        public long FkContractorid { get; set; }
        public string Typedescription { get; set; }
        public string Typecode { get; set; }
        public string Commentname { get; set; }
        public bool Ispaid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblContractor FkContractor { get; set; }
        public ICollection<TblTimekeepingMileage> TblTimekeepingMileage { get; set; }
    }
}
