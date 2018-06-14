using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLog
    {
        public long LogId { get; set; }
        public DateTime? Date { get; set; }
        public string Thread { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string UserName { get; set; }
        public string Assembly { get; set; }
        public string Session { get; set; }
    }
}
