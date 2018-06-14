using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTimekeepingInEfficientieType
    {
        public TblTimekeepingInEfficientieType()
        {
            TblTimekeepingEntryInefficiency = new HashSet<TblTimekeepingEntryInefficiency>();
        }

        public long PkTimekeepinginefficientieTypeid { get; set; }
        public string Timekeepinginefficientietypecode { get; set; }
        public string TimekeepinginefficientietypedescriptionL1 { get; set; }
        public bool? Isactive { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string TimekeepinginefficientietypedescriptionL2 { get; set; }
        public string TimekeepinginefficientietypedescriptionL3 { get; set; }
        public string TimekeepinginefficientietypedescriptionL4 { get; set; }
        public string TimekeepinginefficientietypedescriptionL5 { get; set; }

        public ICollection<TblTimekeepingEntryInefficiency> TblTimekeepingEntryInefficiency { get; set; }
    }
}
