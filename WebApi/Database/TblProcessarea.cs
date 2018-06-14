using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblProcessarea
    {
        public TblProcessarea()
        {
            TblMainSbs = new HashSet<TblMainSbs>();
            TblPermitData = new HashSet<TblPermitData>();
            TblProcessAreaRestrictedRightUserProcessArea = new HashSet<TblProcessAreaRestrictedRightUserProcessArea>();
            TblProcessAreaUser = new HashSet<TblProcessAreaUser>();
            TblProgressResponsible = new HashSet<TblProgressResponsible>();
            TblUnit = new HashSet<TblUnit>();
        }

        public long PkProcessareaid { get; set; }
        public string Processarea { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Processareadescription { get; set; }

        public ICollection<TblMainSbs> TblMainSbs { get; set; }
        public ICollection<TblPermitData> TblPermitData { get; set; }
        public ICollection<TblProcessAreaRestrictedRightUserProcessArea> TblProcessAreaRestrictedRightUserProcessArea { get; set; }
        public ICollection<TblProcessAreaUser> TblProcessAreaUser { get; set; }
        public ICollection<TblProgressResponsible> TblProgressResponsible { get; set; }
        public ICollection<TblUnit> TblUnit { get; set; }
    }
}
