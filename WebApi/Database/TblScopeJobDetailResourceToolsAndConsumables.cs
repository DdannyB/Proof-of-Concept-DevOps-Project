using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeJobDetailResourceToolsAndConsumables
    {
        public long PkScopejobdetailresourcetoolsandconsumablesid { get; set; }
        public long FkScopejobdetailresourceid { get; set; }
        public long FkToolsandconsumablesid { get; set; }
        public long? FkContractorid { get; set; }
        public decimal? Resourcetoolsandconsumablesprice { get; set; }
        public decimal? Resourcetoolsandconsumablesquantity { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblContractor FkContractor { get; set; }
        public TblScopeJobDetailResource FkScopejobdetailresource { get; set; }
        public TblToolsAndConsumables FkToolsandconsumables { get; set; }
    }
}
