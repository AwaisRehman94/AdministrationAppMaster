using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels.Persistence.AutoLeaseLogModels
{
    public partial class IdentityRequestLog
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string UserId { get; set; }
        public string Response { get; set; }
        public string Method { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public string ServerIp { get; set; }
        public string Channel { get; set; }
        public bool? VehicleAgencyRepair { get; set; }
        public string City { get; set; }
    }
}
