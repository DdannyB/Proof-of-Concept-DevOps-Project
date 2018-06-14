﻿using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTimekeepingEntryCircum
    {
        public long PkTimekeepingentrycircumid { get; set; }
        public long FkTimekeepingentryid { get; set; }
        public long FkCircumstanceid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public decimal Hrs { get; set; }

        public TblCircumstance FkCircumstance { get; set; }
        public TblTimekeepingEntry FkTimekeepingentry { get; set; }
    }
}