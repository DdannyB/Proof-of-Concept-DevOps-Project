using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeJobDetailResource
    {
        public TblScopeJobDetailResource()
        {
            TblScopeJobDetailResourceCircumstance = new HashSet<TblScopeJobDetailResourceCircumstance>();
            TblScopeJobDetailResourceEstimate = new HashSet<TblScopeJobDetailResourceEstimate>();
            TblScopeJobDetailResourceMaterial = new HashSet<TblScopeJobDetailResourceMaterial>();
            TblScopeJobDetailResourceTarget = new HashSet<TblScopeJobDetailResourceTarget>();
            TblScopeJobDetailResourceToolsAndConsumables = new HashSet<TblScopeJobDetailResourceToolsAndConsumables>();
        }

        public long PkScopejobdetailresourceid { get; set; }
        public long FkScopejobdetailid { get; set; }
        public long? FkJobdetailresourceid { get; set; }
        public long FkJobdetailresourcedataid { get; set; }
        public long FkResourceid { get; set; }
        public int? Scopejobdetailresourcesortorder { get; set; }
        public DateTime? Resourceactualstartdate { get; set; }
        public DateTime? Resourceactualfinishdate { get; set; }
        public bool Resourceisautoapprove { get; set; }
        public bool Resourceismanualactualtimeoverride { get; set; }
        public bool Resourceisready { get; set; }
        public string Resourcelocation { get; set; }
        public int? Resourceprogress { get; set; }
        public string Resourceprogressmode { get; set; }
        public string Resourceprogressticketcode { get; set; }
        public string Resourceprogressusername { get; set; }
        public string Resourceqcticketcode { get; set; }
        public string Resourceqcticketcodeold { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkCostcenterid { get; set; }

        public TblCostCenter FkCostcenter { get; set; }
        public TblJobDetailResource FkJobdetailresource { get; set; }
        public TblJobDetailResourceData FkJobdetailresourcedata { get; set; }
        public TblResource FkResource { get; set; }
        public TblScopeJobDetail FkScopejobdetail { get; set; }
        public ICollection<TblScopeJobDetailResourceCircumstance> TblScopeJobDetailResourceCircumstance { get; set; }
        public ICollection<TblScopeJobDetailResourceEstimate> TblScopeJobDetailResourceEstimate { get; set; }
        public ICollection<TblScopeJobDetailResourceMaterial> TblScopeJobDetailResourceMaterial { get; set; }
        public ICollection<TblScopeJobDetailResourceTarget> TblScopeJobDetailResourceTarget { get; set; }
        public ICollection<TblScopeJobDetailResourceToolsAndConsumables> TblScopeJobDetailResourceToolsAndConsumables { get; set; }
    }
}
