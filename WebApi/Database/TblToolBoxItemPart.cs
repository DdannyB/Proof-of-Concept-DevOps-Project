using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblToolBoxItemPart
    {
        public long PkToolboxitempartid { get; set; }
        public long FkToolboxitemid { get; set; }
        public int Basepermititemparttype { get; set; }
        public string Textvalue { get; set; }
        public double Xpos { get; set; }
        public double Ypos { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? Datadrivenforeignkey { get; set; }
        public int? Toolboxitempartsubtype { get; set; }
        public bool? Islinked { get; set; }
        public int? Signaturestamptype { get; set; }
        public int? Stampandsignatureposition { get; set; }

        public TblToolBoxItem FkToolboxitem { get; set; }
    }
}
