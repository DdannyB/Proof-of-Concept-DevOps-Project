using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSchedule
    {
        public TblSchedule()
        {
            TblCertificate = new HashSet<TblCertificate>();
            TblDiaWthSchedCoupling = new HashSet<TblDiaWthSchedCoupling>();
            TblMaterialLibrary = new HashSet<TblMaterialLibrary>();
            TblPart = new HashSet<TblPart>();
            TblScheduleAlternative = new HashSet<TblScheduleAlternative>();
            TblWeldConnectionPart = new HashSet<TblWeldConnectionPart>();
        }

        public long PkScheduleid { get; set; }
        public string Scheddescription { get; set; }
        public decimal? Schedvalue { get; set; }
        public bool Iscustom { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblCertificate> TblCertificate { get; set; }
        public ICollection<TblDiaWthSchedCoupling> TblDiaWthSchedCoupling { get; set; }
        public ICollection<TblMaterialLibrary> TblMaterialLibrary { get; set; }
        public ICollection<TblPart> TblPart { get; set; }
        public ICollection<TblScheduleAlternative> TblScheduleAlternative { get; set; }
        public ICollection<TblWeldConnectionPart> TblWeldConnectionPart { get; set; }
    }
}
