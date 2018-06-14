using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLubricant
    {
        public TblLubricant()
        {
            TblBolting = new HashSet<TblBolting>();
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
        }

        public long PkLubricantid { get; set; }
        public string Lubricantcode { get; set; }
        public string Lubricantdescription { get; set; }
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
