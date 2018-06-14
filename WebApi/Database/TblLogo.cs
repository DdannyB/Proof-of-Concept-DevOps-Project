using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLogo
    {
        public TblLogo()
        {
            TblProject = new HashSet<TblProject>();
            TblSettingFkDefaultlogo = new HashSet<TblSetting>();
            TblSettingFkMasterdatainterfacelogo = new HashSet<TblSetting>();
        }

        public long PkLogoid { get; set; }
        public string Logodescription { get; set; }
        public byte[] Logo { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblProject> TblProject { get; set; }
        public ICollection<TblSetting> TblSettingFkDefaultlogo { get; set; }
        public ICollection<TblSetting> TblSettingFkMasterdatainterfacelogo { get; set; }
    }
}
