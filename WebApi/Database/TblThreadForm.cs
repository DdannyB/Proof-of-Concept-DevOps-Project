using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblThreadForm
    {
        public TblThreadForm()
        {
            TblBolting = new HashSet<TblBolting>();
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
        }

        public long PkThreadformid { get; set; }
        public string Threadformcode { get; set; }
        public string Threadformdescription { get; set; }
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
