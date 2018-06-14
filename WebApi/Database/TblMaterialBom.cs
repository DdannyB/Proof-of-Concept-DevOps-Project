using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMaterialBom
    {
        public long PkMaterialbomid { get; set; }
        public string Functionallocation { get; set; }
        public string Equipmenttag { get; set; }
        public string Assemblyarticledescription { get; set; }
        public long FkMateriallibraryid { get; set; }
        public decimal? Articleminquantity { get; set; }
        public string Positiontxt1 { get; set; }
        public string Positiontxt2 { get; set; }
        public string Sortordernr { get; set; }
        public string Lngtxt { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool? Isstock { get; set; }

        public TblMaterialLibrary FkMateriallibrary { get; set; }
    }
}
