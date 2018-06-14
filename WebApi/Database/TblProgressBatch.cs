﻿using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblProgressBatch
    {
        public TblProgressBatch()
        {
            TblProgressBatchReport = new HashSet<TblProgressBatchReport>();
        }

        public long PkProgressbatchid { get; set; }
        public long FkProjectid { get; set; }
        public string Title { get; set; }
        public bool Showindex { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProject FkProject { get; set; }
        public ICollection<TblProgressBatchReport> TblProgressBatchReport { get; set; }
    }
}