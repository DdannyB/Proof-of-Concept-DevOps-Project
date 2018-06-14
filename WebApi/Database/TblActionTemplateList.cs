using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblActionTemplateList
    {
        public TblActionTemplateList()
        {
            TblActionTemplate = new HashSet<TblActionTemplate>();
        }

        public long PkActiontemplatelistid { get; set; }
        public string Actiontemplatelistname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblActionTemplate> TblActionTemplate { get; set; }
    }
}
