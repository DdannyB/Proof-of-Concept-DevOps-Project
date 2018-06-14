using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBoltType
    {
        public TblBoltType()
        {
            TblBlindPointActivity = new HashSet<TblBlindPointActivity>();
            TblBoltingFkAdditionalbolttype = new HashSet<TblBolting>();
            TblBoltingFkBolttype = new HashSet<TblBolting>();
            TblMaterialPipeSpec = new HashSet<TblMaterialPipeSpec>();
            TblTemplateBlindPointActivity = new HashSet<TblTemplateBlindPointActivity>();
            TblTemplateBlindPointFkAdditionalbolttype = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkBolttype = new HashSet<TblTemplateBlindPoint>();
        }

        public long PkBolttypeid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblBlindPointActivity> TblBlindPointActivity { get; set; }
        public ICollection<TblBolting> TblBoltingFkAdditionalbolttype { get; set; }
        public ICollection<TblBolting> TblBoltingFkBolttype { get; set; }
        public ICollection<TblMaterialPipeSpec> TblMaterialPipeSpec { get; set; }
        public ICollection<TblTemplateBlindPointActivity> TblTemplateBlindPointActivity { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkAdditionalbolttype { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkBolttype { get; set; }
    }
}
