﻿using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class ClientCorsOrigins
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Origin { get; set; }

        public Clients Client { get; set; }
    }
}
