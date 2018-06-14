using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblException
    {
        public TblException()
        {
            TblExceptionCalendar = new HashSet<TblExceptionCalendar>();
            TblExceptionContractor = new HashSet<TblExceptionContractor>();
            TblExceptionProject = new HashSet<TblExceptionProject>();
            TblExceptionResource = new HashSet<TblExceptionResource>();
        }

        public long PkExceptionid { get; set; }
        public string Description { get; set; }
        public int Exceptiontype { get; set; }
        public string Exceptionworkhours { get; set; }
        public int Recurrenceperiodtype { get; set; }
        public int? Recurrenceperiodday { get; set; }
        public int? Recurrenceperiodweek { get; set; }
        public int? Recurrenceperiodmonth { get; set; }
        public int? Recurrenceperiodyear { get; set; }
        public int Recurrencepatterntype { get; set; }
        public int? Recurrenceweekdayordinal { get; set; }
        public int? Recurrenceweekday { get; set; }
        public int? Recurrencemonth { get; set; }
        public DateTime Recurrencestart { get; set; }
        public int Recurrencetype { get; set; }
        public DateTime? Recurrenceend { get; set; }
        public int? Recurrencenofoccurrences { get; set; }
        public bool Validforallcalendars { get; set; }
        public bool Validforallcontractors { get; set; }
        public bool Validforallresources { get; set; }
        public int? Recurrencedayofmonth { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Validforallprojects { get; set; }

        public ICollection<TblExceptionCalendar> TblExceptionCalendar { get; set; }
        public ICollection<TblExceptionContractor> TblExceptionContractor { get; set; }
        public ICollection<TblExceptionProject> TblExceptionProject { get; set; }
        public ICollection<TblExceptionResource> TblExceptionResource { get; set; }
    }
}
