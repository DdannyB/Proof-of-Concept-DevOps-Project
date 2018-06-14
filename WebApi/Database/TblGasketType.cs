using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblGasketType
    {
        public TblGasketType()
        {
            TblBlindPointActivity = new HashSet<TblBlindPointActivity>();
            TblBolting = new HashSet<TblBolting>();
            TblMaterialPipeSpec = new HashSet<TblMaterialPipeSpec>();
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointActivity = new HashSet<TblTemplateBlindPointActivity>();
        }

        public long PkGaskettypeid { get; set; }
        public string Gaskettypecode { get; set; }
        public string Gaskettypedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblBlindPointActivity> TblBlindPointActivity { get; set; }
        public ICollection<TblBolting> TblBolting { get; set; }
        public ICollection<TblMaterialPipeSpec> TblMaterialPipeSpec { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPoint { get; set; }
        public ICollection<TblTemplateBlindPointActivity> TblTemplateBlindPointActivity { get; set; }
    }
}
