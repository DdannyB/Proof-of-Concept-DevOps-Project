using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMaterial
    {
        public TblMaterial()
        {
            TblBlindPointActivityMaterial = new HashSet<TblBlindPointActivityMaterial>();
            TblScopeJobDetailResourceMaterial = new HashSet<TblScopeJobDetailResourceMaterial>();
            TblScopeMaterial = new HashSet<TblScopeMaterial>();
            TblTemplateBlindpointActivityMaterial = new HashSet<TblTemplateBlindpointActivityMaterial>();
        }

        public long PkMaterialid { get; set; }
        public long? FkUserid { get; set; }
        public long FkMainmaterialgroupid { get; set; }
        public long FkSubmaterialgroupid { get; set; }
        public long? FkContractorid { get; set; }
        public decimal Quantity { get; set; }
        public string Articledescription { get; set; }
        public string Unit { get; set; }
        public string Articlenumber { get; set; }
        public string Stockcode { get; set; }
        public string Size { get; set; }
        public string Lbs { get; set; }
        public string Dn { get; set; }
        public string Pn { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Material { get; set; }
        public string Wt { get; set; }
        public string Sched { get; set; }
        public string Certificate { get; set; }
        public string Heatnumber { get; set; }
        public string Specreq { get; set; }
        public DateTime? Requiredatsitedate { get; set; }
        public DateTime? Estimateddeliverydate { get; set; }
        public DateTime? Actualdeliverydate { get; set; }
        public string Rowtype { get; set; }
        public string Requiredatsitetype { get; set; }
        public decimal? Price { get; set; }
        public string Custompurchaseordertext { get; set; }
        public string Requestorname { get; set; }
        public DateTime? Requestordate { get; set; }
        public string Status { get; set; }
        public string Exportnumber { get; set; }
        public string Quotationrequestnumber { get; set; }
        public bool Isstock { get; set; }
        public decimal? Additionalcost { get; set; }
        public string Purchaseordernumber { get; set; }
        public string Legacyarticlenumber1 { get; set; }
        public string Legacyarticlenumber2 { get; set; }
        public string Materialmemo { get; set; }
        public bool Isexpediting { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int? Requestnumber { get; set; }
        public string Dia { get; set; }
        public string Unloadingpoint { get; set; }
        public string Trackingnumber { get; set; }
        public string Storagelocation { get; set; }
        public string Goodsrecipient { get; set; }
        public long? FkFollowupuserid { get; set; }
        public bool Ismaterialslongdelivery { get; set; }

        public TblContractor FkContractor { get; set; }
        public TblUser FkFollowupuser { get; set; }
        public TblMainMaterialGroup FkMainmaterialgroup { get; set; }
        public TblSubMaterialGroup FkSubmaterialgroup { get; set; }
        public TblUser FkUser { get; set; }
        public ICollection<TblBlindPointActivityMaterial> TblBlindPointActivityMaterial { get; set; }
        public ICollection<TblScopeJobDetailResourceMaterial> TblScopeJobDetailResourceMaterial { get; set; }
        public ICollection<TblScopeMaterial> TblScopeMaterial { get; set; }
        public ICollection<TblTemplateBlindpointActivityMaterial> TblTemplateBlindpointActivityMaterial { get; set; }
    }
}
