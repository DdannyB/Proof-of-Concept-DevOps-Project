using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblGridViewInfoActiveGridFilterInfo
    {
        public long PkGridviewinfoactivegridfilterinfoid { get; set; }
        public long FkGridviewinfoid { get; set; }
        public long FkGridfilterinfoid { get; set; }
        public long? FkProjectid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblGridFilterinfo FkGridfilterinfo { get; set; }
        public TblGridViewinfo FkGridviewinfo { get; set; }
        public TblProject FkProject { get; set; }
    }
}
