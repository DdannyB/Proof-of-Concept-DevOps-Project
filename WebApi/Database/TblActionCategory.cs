using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblActionCategory
    {
        public TblActionCategory()
        {
            TblActionTemplate = new HashSet<TblActionTemplate>();
            TblChangeRequestAction = new HashSet<TblChangeRequestAction>();
        }

        public long PkActioncategoryid { get; set; }
        public string Actioncategorycode { get; set; }
        public string Actioncategorydescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblActionTemplate> TblActionTemplate { get; set; }
        public ICollection<TblChangeRequestAction> TblChangeRequestAction { get; set; }
    }
}
