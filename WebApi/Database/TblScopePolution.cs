using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopePolution
    {
        public long PkScopepolutionid { get; set; }
        public long FkScopeid { get; set; }
        public string Memo { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkCleanequipmentpartid { get; set; }
        public long FkCleanindexid { get; set; }
        public long? FkCleaningmethodid { get; set; }

        public TblCleanEquipmentPart FkCleanequipmentpart { get; set; }
        public TblCleanIndex FkCleanindex { get; set; }
        public TblCleaningMethod FkCleaningmethod { get; set; }
        public TblScope FkScope { get; set; }
    }
}
