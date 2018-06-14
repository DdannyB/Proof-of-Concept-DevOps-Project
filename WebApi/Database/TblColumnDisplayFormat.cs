using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblColumnDisplayFormat
    {
        public TblColumnDisplayFormat()
        {
            TblColumnDisplayFormatData = new HashSet<TblColumnDisplayFormatData>();
        }

        public long PkColumndisplayformatid { get; set; }
        public string Fieldname { get; set; }
        public long FkUserid { get; set; }
        public int Displayformattype { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblUser FkUser { get; set; }
        public ICollection<TblColumnDisplayFormatData> TblColumnDisplayFormatData { get; set; }
    }
}
