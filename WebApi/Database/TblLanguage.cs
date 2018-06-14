using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLanguage
    {
        public TblLanguage()
        {
            TblUser = new HashSet<TblUser>();
        }

        public long PkLanguageid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Fontfamily { get; set; }

        public ICollection<TblUser> TblUser { get; set; }
    }
}
