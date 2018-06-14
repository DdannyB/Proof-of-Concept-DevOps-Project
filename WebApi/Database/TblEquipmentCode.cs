using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblEquipmentCode
    {
        public TblEquipmentCode()
        {
            TblScope = new HashSet<TblScope>();
            TblShortcode = new HashSet<TblShortcode>();
        }

        public long PkEquipmentcodeid { get; set; }
        public string Code { get; set; }
        public string EquipmentcodedescriptionL1 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string EquipmentcodedescriptionL2 { get; set; }
        public string EquipmentcodedescriptionL3 { get; set; }
        public string EquipmentcodedescriptionL4 { get; set; }
        public string EquipmentcodedescriptionL5 { get; set; }

        public ICollection<TblScope> TblScope { get; set; }
        public ICollection<TblShortcode> TblShortcode { get; set; }
    }
}
