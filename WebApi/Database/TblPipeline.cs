using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPipeline
    {
        public TblPipeline()
        {
            TblLisl = new HashSet<TblLisl>();
            TblPidRevisionPipeLine = new HashSet<TblPidRevisionPipeLine>();
            TblPipeLineProduct = new HashSet<TblPipeLineProduct>();
            TblPipelineConnection = new HashSet<TblPipelineConnection>();
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
            TblWeldConnection = new HashSet<TblWeldConnection>();
        }

        public long PkPipelineid { get; set; }
        public string Linenumber { get; set; }
        public long? FkPipelineconnectionfromid { get; set; }
        public long? FkPipelineconnectiontoid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkUnitid { get; set; }
        public string Connectionfromdescription { get; set; }
        public string Connectiontodescription { get; set; }

        public TblPipelineConnection FkPipelineconnectionfrom { get; set; }
        public TblPipelineConnection FkPipelineconnectionto { get; set; }
        public TblUnit FkUnit { get; set; }
        public ICollection<TblLisl> TblLisl { get; set; }
        public ICollection<TblPidRevisionPipeLine> TblPidRevisionPipeLine { get; set; }
        public ICollection<TblPipeLineProduct> TblPipeLineProduct { get; set; }
        public ICollection<TblPipelineConnection> TblPipelineConnection { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPoint { get; set; }
        public ICollection<TblWeldConnection> TblWeldConnection { get; set; }
    }
}
