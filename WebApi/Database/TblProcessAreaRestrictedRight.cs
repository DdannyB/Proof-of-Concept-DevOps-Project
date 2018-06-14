using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblProcessAreaRestrictedRight
    {
        public TblProcessAreaRestrictedRight()
        {
            TblProcessAreaRestrictedRightUserProcessArea = new HashSet<TblProcessAreaRestrictedRightUserProcessArea>();
        }

        public long PkProcessarearestrictedrightid { get; set; }
        public long FkRightid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblRight FkRight { get; set; }
        public ICollection<TblProcessAreaRestrictedRightUserProcessArea> TblProcessAreaRestrictedRightUserProcessArea { get; set; }
    }
}
