using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPipelineConnection
    {
        public TblPipelineConnection()
        {
            TblPipelineFkPipelineconnectionfrom = new HashSet<TblPipeline>();
            TblPipelineFkPipelineconnectionto = new HashSet<TblPipeline>();
        }

        public long PkPipelineconnectionid { get; set; }
        public long? FkPlantdataid { get; set; }
        public long? FkPipelineid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblPipeline FkPipeline { get; set; }
        public TblPlantData FkPlantdata { get; set; }
        public ICollection<TblPipeline> TblPipelineFkPipelineconnectionfrom { get; set; }
        public ICollection<TblPipeline> TblPipelineFkPipelineconnectionto { get; set; }
    }
}
