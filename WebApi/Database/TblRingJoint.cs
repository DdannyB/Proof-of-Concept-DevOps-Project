using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblRingJoint
    {
        public TblRingJoint()
        {
            TblBolting = new HashSet<TblBolting>();
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
        }

        public long PkRingjointid { get; set; }
        public string Ringjointcode { get; set; }
        public string Ringjointdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblBolting> TblBolting { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPoint { get; set; }
    }
}
