using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class Message
    {
        public Message()
        {
            NotificationMessage = new HashSet<NotificationMessage>();
        }

        public long PkMessageid { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }

        public ICollection<NotificationMessage> NotificationMessage { get; set; }
    }
}
