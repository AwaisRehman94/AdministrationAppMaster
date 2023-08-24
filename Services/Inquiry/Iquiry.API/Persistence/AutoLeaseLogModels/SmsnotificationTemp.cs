using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels.Persistence.AutoLeaseLogModels
{
    public partial class SmsnotificationTemp
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string MobileNumber { get; set; }
        public string Smsmessage { get; set; }
        public string SequenceNumber { get; set; }
        public string ReferenceId { get; set; }
        public DateTime? PolicyExpiryDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? NotificationNo { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public bool? VehicleAgencyRepair { get; set; }
        public string City { get; set; }
    }
}
