using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTimekeepingEntryType
    {
        public TblTimekeepingEntryType()
        {
            TblTimekeepingEntry = new HashSet<TblTimekeepingEntry>();
        }

        public long PkTimekeepingentrytypeid { get; set; }
        public long? FkContractorid { get; set; }
        public string Timekeepingentrytypecode { get; set; }
        public string Timekeepingentrytypedescription { get; set; }
        public bool Isbillable { get; set; }
        public bool Isactive { get; set; }
        public bool Isdefault { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblContractor FkContractor { get; set; }
        public ICollection<TblTimekeepingEntry> TblTimekeepingEntry { get; set; }
    }
}
