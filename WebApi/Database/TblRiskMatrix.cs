using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblRiskMatrix
    {
        public int PkRiskmatrixid { get; set; }
        public int Effectkey { get; set; }
        public int Probabilitykey { get; set; }
        public string Resultcode { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int? Resultvalue { get; set; }
        public int? Backcolor { get; set; }
        public bool? Ismaxrisk { get; set; }
        public int Sortorder { get; set; }
        public bool Jfactorarea { get; set; }
        public long FkApplicationid { get; set; }

        public TblApplication FkApplication { get; set; }
    }
}
