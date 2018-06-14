using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblActivity
    {
        public TblActivity()
        {
            TblActivityBlindtype = new HashSet<TblActivityBlindtype>();
            TblBlindPointActivity = new HashSet<TblBlindPointActivity>();
            TblBlindTypeNormPosActivity = new HashSet<TblBlindTypeNormPosActivity>();
            TblBlindTypeNormPosActivityNormbase = new HashSet<TblBlindTypeNormPosActivityNormbase>();
            TblBlindTypeNormPosActivityTemplate = new HashSet<TblBlindTypeNormPosActivityTemplate>();
            TblTemplateBlindPointActivity = new HashSet<TblTemplateBlindPointActivity>();
        }

        public long PkActivityid { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Activitycode { get; set; }
        public int Normpostype { get; set; }

        public ICollection<TblActivityBlindtype> TblActivityBlindtype { get; set; }
        public ICollection<TblBlindPointActivity> TblBlindPointActivity { get; set; }
        public ICollection<TblBlindTypeNormPosActivity> TblBlindTypeNormPosActivity { get; set; }
        public ICollection<TblBlindTypeNormPosActivityNormbase> TblBlindTypeNormPosActivityNormbase { get; set; }
        public ICollection<TblBlindTypeNormPosActivityTemplate> TblBlindTypeNormPosActivityTemplate { get; set; }
        public ICollection<TblTemplateBlindPointActivity> TblTemplateBlindPointActivity { get; set; }
    }
}
