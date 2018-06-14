using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCleanEquipmentPart
    {
        public TblCleanEquipmentPart()
        {
            TblScopePolution = new HashSet<TblScopePolution>();
        }

        public long PkCleanequipmentpartid { get; set; }
        public string Cleanequipmentpart { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblScopePolution> TblScopePolution { get; set; }
    }
}
