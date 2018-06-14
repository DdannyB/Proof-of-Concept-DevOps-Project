using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblFillerMaterialGroup
    {
        public TblFillerMaterialGroup()
        {
            TblFillerMaterial = new HashSet<TblFillerMaterial>();
        }

        public long PkFillermaterialgroupid { get; set; }
        public string Fillermaterialgroupcode { get; set; }
        public string Fillermaterialgroupdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblFillerMaterial> TblFillerMaterial { get; set; }
    }
}
