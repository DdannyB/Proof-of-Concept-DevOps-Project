using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblColumnDisplayFormatData
    {
        public long PkColumndisplayformatdataid { get; set; }
        public string Value { get; set; }
        public long FkColumndisplayformatid { get; set; }
        public int Valuetype { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblColumnDisplayFormat FkColumndisplayformat { get; set; }
    }
}
