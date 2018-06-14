using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTimekeepingSubCode
    {
        public TblTimekeepingSubCode()
        {
            TblResource = new HashSet<TblResource>();
            TblUser = new HashSet<TblUser>();
        }

        public long PkTimekeepingsubcodeid { get; set; }
        public long FkTimekeepingmaincodeid { get; set; }
        public string Subcodedescr { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblTimekeepingMainCode FkTimekeepingmaincode { get; set; }
        public ICollection<TblResource> TblResource { get; set; }
        public ICollection<TblUser> TblUser { get; set; }
    }
}
