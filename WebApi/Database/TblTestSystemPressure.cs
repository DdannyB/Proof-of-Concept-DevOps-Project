using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTestSystemPressure
    {
        public long PkTestsystempressureid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
    }
}
