using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class Touchscreen
    {
        public long Id { get; set; }
        public Guid SecretKey { get; set; }
        public string ComputerName { get; set; }
        public bool IsActive { get; set; }
        public string Pincode { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }
    }
}
