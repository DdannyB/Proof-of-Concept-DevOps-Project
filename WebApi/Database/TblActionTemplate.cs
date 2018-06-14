using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblActionTemplate
    {
        public TblActionTemplate()
        {
            TblChangeRequestAction = new HashSet<TblChangeRequestAction>();
        }

        public long PkActiontemplateid { get; set; }
        public long FkActiontemplatelistid { get; set; }
        public long? FkActioncategoryid { get; set; }
        public long? FkWorkflowstateid { get; set; }
        public string Actiontemplatedescription { get; set; }
        public string Actiontemplatememo { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblActionCategory FkActioncategory { get; set; }
        public TblActionTemplateList FkActiontemplatelist { get; set; }
        public TblWorkflowState FkWorkflowstate { get; set; }
        public ICollection<TblChangeRequestAction> TblChangeRequestAction { get; set; }
    }
}
