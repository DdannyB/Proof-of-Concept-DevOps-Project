using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblShortcodeTemplate
    {
        public TblShortcodeTemplate()
        {
            TblShortcodeTemplateWpcode = new HashSet<TblShortcodeTemplateWpcode>();
        }

        public long PkShortcodetemplateid { get; set; }
        public long FkShortcodeid { get; set; }
        public long FkProjectid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Templatenr { get; set; }
        public string Templatedescr { get; set; }
        public decimal? Wpholderhrs { get; set; }
        public bool Isdefaulttemplate { get; set; }

        public TblProject FkProject { get; set; }
        public TblShortcode FkShortcode { get; set; }
        public ICollection<TblShortcodeTemplateWpcode> TblShortcodeTemplateWpcode { get; set; }
    }
}
