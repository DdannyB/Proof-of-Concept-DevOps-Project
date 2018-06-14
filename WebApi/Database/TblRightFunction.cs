﻿using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblRightFunction
    {
        public TblRightFunction()
        {
            TblRight = new HashSet<TblRight>();
        }

        public long PkRightfunctionid { get; set; }
        public long FkApplicationid { get; set; }
        public long FkRightgroupid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int? Sortorder { get; set; }

        public TblApplication FkApplication { get; set; }
        public TblRightGroup FkRightgroup { get; set; }
        public ICollection<TblRight> TblRight { get; set; }
    }
}