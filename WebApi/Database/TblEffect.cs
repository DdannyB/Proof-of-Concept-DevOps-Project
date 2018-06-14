using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblEffect
    {
        public long PkEffectid { get; set; }
        public int Effectkey { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Category { get; set; }
        public long FkApplicationid { get; set; }

        public TblApplication FkApplication { get; set; }
    }
}
