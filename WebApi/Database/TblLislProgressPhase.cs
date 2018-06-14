using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLislProgressPhase
    {
        public TblLislProgressPhase()
        {
            TblLislProgress = new HashSet<TblLislProgress>();
            TblUserLislProgressPhase = new HashSet<TblUserLislProgressPhase>();
        }

        public long PkLislprogressphaseid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Isprefab { get; set; }
        public bool Isfield { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblLislProgress> TblLislProgress { get; set; }
        public ICollection<TblUserLislProgressPhase> TblUserLislProgressPhase { get; set; }
    }
}
