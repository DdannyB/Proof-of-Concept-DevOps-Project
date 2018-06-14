﻿using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBudgetCenterAllocation
    {
        public TblBudgetCenterAllocation()
        {
            TblScope = new HashSet<TblScope>();
        }

        public long PkBudgetcenterallocationid { get; set; }
        public string Budgetcenter { get; set; }
        public string Description { get; set; }
        public string Cbs { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblScope> TblScope { get; set; }
    }
}