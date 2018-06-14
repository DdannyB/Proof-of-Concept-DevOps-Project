using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTimekeepingMainCode
    {
        public TblTimekeepingMainCode()
        {
            TblTimekeepingSubCode = new HashSet<TblTimekeepingSubCode>();
        }

        public long PkTimekeepingmaincodeid { get; set; }
        public string Maincodedescr { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblTimekeepingSubCode> TblTimekeepingSubCode { get; set; }
    }
}
