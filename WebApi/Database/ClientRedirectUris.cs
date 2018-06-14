using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class ClientRedirectUris
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string RedirectUri { get; set; }

        public Clients Client { get; set; }
    }
}
