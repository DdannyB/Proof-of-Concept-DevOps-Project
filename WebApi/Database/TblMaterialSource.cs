using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMaterialSource
    {
        public TblMaterialSource()
        {
            TblMaterialDistribution = new HashSet<TblMaterialDistribution>();
            TblMaterialReceived = new HashSet<TblMaterialReceived>();
        }

        public long PkMaterialsourceid { get; set; }
        public string Articlenumber { get; set; }
        public int? Materialrequestnumber { get; set; }
        public string Legacyarticlenumber1 { get; set; }
        public string Legacyarticlenumber2 { get; set; }
        public long FkProjectid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProject FkProject { get; set; }
        public ICollection<TblMaterialDistribution> TblMaterialDistribution { get; set; }
        public ICollection<TblMaterialReceived> TblMaterialReceived { get; set; }
    }
}
