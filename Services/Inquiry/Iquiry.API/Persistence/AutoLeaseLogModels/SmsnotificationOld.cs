using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels.Persistence.AutoLeaseLogModels
{
    public partial class SmsnotificationOld
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string MobileNumber { get; set; }
        public string Smsmessage { get; set; }
        public string SequenceNumber { get; set; }
        public string ReferenceId { get; set; }
        public bool? VehicleAgencyRepair { get; set; }
        public string City { get; set; }
    }
}
