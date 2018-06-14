using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblResource
    {
        public TblResource()
        {
            TblBasePermitMaintenanceStrategyDetails = new HashSet<TblBasePermitMaintenanceStrategyDetails>();
            TblExceptionResource = new HashSet<TblExceptionResource>();
            TblHandoverGroupSub = new HashSet<TblHandoverGroupSub>();
            TblJobDetailResource = new HashSet<TblJobDetailResource>();
            TblLibraryProcurementContractPricelist = new HashSet<TblLibraryProcurementContractPricelist>();
            TblProgressResponsible = new HashSet<TblProgressResponsible>();
            TblResourceConstraint = new HashSet<TblResourceConstraint>();
            TblScopeJobDetailResource = new HashSet<TblScopeJobDetailResource>();
            TblUser = new HashSet<TblUser>();
            TblUserMemberQcResource = new HashSet<TblUserMemberQcResource>();
            TblWallpaperDynamicColDetail = new HashSet<TblWallpaperDynamicColDetail>();
        }

        public long PkResourceid { get; set; }
        public long FkSubdisciplineid { get; set; }
        public string Resourcecode { get; set; }
        public string ResourcedescriptionL1 { get; set; }
        public string ResourcedescriptionL2 { get; set; }
        public string ResourcedescriptionL3 { get; set; }
        public string ResourcedescriptionL4 { get; set; }
        public string ResourcedescriptionL5 { get; set; }
        public int Resourcecolor { get; set; }
        public bool Autoapprove { get; set; }
        public string Activitytype { get; set; }
        public string Workcenter { get; set; }
        public bool Iswelditresource { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkTimekeepingsubcodeid { get; set; }
        public int Resourcetype { get; set; }
        public long? FkDefaultcostcenterid { get; set; }

        public TblCostCenter FkDefaultcostcenter { get; set; }
        public TblSubDiscipline FkSubdiscipline { get; set; }
        public TblTimekeepingSubCode FkTimekeepingsubcode { get; set; }
        public ICollection<TblBasePermitMaintenanceStrategyDetails> TblBasePermitMaintenanceStrategyDetails { get; set; }
        public ICollection<TblExceptionResource> TblExceptionResource { get; set; }
        public ICollection<TblHandoverGroupSub> TblHandoverGroupSub { get; set; }
        public ICollection<TblJobDetailResource> TblJobDetailResource { get; set; }
        public ICollection<TblLibraryProcurementContractPricelist> TblLibraryProcurementContractPricelist { get; set; }
        public ICollection<TblProgressResponsible> TblProgressResponsible { get; set; }
        public ICollection<TblResourceConstraint> TblResourceConstraint { get; set; }
        public ICollection<TblScopeJobDetailResource> TblScopeJobDetailResource { get; set; }
        public ICollection<TblUser> TblUser { get; set; }
        public ICollection<TblUserMemberQcResource> TblUserMemberQcResource { get; set; }
        public ICollection<TblWallpaperDynamicColDetail> TblWallpaperDynamicColDetail { get; set; }
    }
}
