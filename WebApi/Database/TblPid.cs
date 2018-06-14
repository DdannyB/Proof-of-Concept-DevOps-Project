using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPid
    {
        public TblPid()
        {
            TblPidRevision = new HashSet<TblPidRevision>();
            TblPlantDataPid = new HashSet<TblPlantDataPid>();
        }

        public long PkPidid { get; set; }
        public string Pidname { get; set; }
        public string Piddescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public DateTime? Inactivedate { get; set; }
        public string Inactiveuser { get; set; }

        public ICollection<TblPidRevision> TblPidRevision { get; set; }
        public ICollection<TblPlantDataPid> TblPlantDataPid { get; set; }
    }
}
