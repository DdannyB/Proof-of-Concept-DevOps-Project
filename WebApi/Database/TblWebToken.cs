using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWebToken
    {
        public string TokenKey { get; set; }
        public string Token { get; set; }
        public DateTime Expiresdate { get; set; }
        public short Tokentype { get; set; }
    }
}
