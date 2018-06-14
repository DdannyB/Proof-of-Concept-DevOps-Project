using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class Recipient
    {
        public long PkRecipientid { get; set; }
        public long FkNotificationmessageid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Recipienttype { get; set; }

        public NotificationMessage FkNotificationmessage { get; set; }
    }
}
