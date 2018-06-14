using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblAreaCode
    {
        public TblAreaCode()
        {
            TblJobDetailData = new HashSet<TblJobDetailData>();
            TblPermitData = new HashSet<TblPermitData>();
            TblPlantData = new HashSet<TblPlantData>();
            TblScope = new HashSet<TblScope>();
        }

        public long PkAreacodeid { get; set; }
        public string Areacodecode { get; set; }
        public string Areacodedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblJobDetailData> TblJobDetailData { get; set; }
        public ICollection<TblPermitData> TblPermitData { get; set; }
        public ICollection<TblPlantData> TblPlantData { get; set; }
        public ICollection<TblScope> TblScope { get; set; }
    }
}
