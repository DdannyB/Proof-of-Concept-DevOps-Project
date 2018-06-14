using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class NotificationMessage
    {
        public NotificationMessage()
        {
            Recipient = new HashSet<Recipient>();
        }

        public long PkNotificationmessageid { get; set; }
        public long FkMessageid { get; set; }
        public int Status { get; set; }
        public int Retrycount { get; set; }

        public Message FkMessage { get; set; }
        public ICollection<Recipient> Recipient { get; set; }
    }
}
