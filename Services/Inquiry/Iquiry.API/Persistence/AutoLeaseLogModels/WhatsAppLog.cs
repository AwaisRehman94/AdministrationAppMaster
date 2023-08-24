using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels.Persistence.AutoLeaseLogModels
{
    public partial class WhatsAppLog
    {
        public int Id { get; set; }
        public string MobileNumber { get; set; }
        public string WhatsAppMessage { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Method { get; set; }
        public string ServiceRequest { get; set; }
        public string ServiceResponse { get; set; }
        public double? ServiceResponseTimeInSeconds { get; set; }
        public string ReferenceId { get; set; }
        public bool? VehicleAgencyRepair { get; set; }
        public string City { get; set; }
    }
}
