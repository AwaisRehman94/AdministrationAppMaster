using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels.Persistence.AutoLeaseLogModels
{
    public partial class OwnDamageSmslog
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string MobileNumber { get; set; }
        public string Smsmessage { get; set; }
        public string PolicyNo { get; set; }
        public string ExternalId { get; set; }
        public DateTime? PolicyExpiryDate { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public bool? VehicleAgencyRepair { get; set; }
        public string City { get; set; }
    }
}
