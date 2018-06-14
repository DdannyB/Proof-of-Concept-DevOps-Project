using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTestSystemMedium
    {
        public TblTestSystemMedium()
        {
            TblPlantCustom = new HashSet<TblPlantCustom>();
            TblTestSystem = new HashSet<TblTestSystem>();
        }

        public long PkTestsystemmediumid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblPlantCustom> TblPlantCustom { get; set; }
        public ICollection<TblTestSystem> TblTestSystem { get; set; }
    }
}
