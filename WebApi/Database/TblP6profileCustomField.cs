using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblP6profileCustomField
    {
        public long PkP6profilecustomfieldid { get; set; }
        public long FkP6profileid { get; set; }
        public long FkP6customfieldid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblP6customField FkP6customfield { get; set; }
        public TblP6profile FkP6profile { get; set; }
    }
}
