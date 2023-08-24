using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels.Persistence.AutoLeaseLogModels
{
    public partial class PdfGenerationLog
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ReferenceId { get; set; }
        public string PolicyNo { get; set; }
        public int? InsuranceTypeCode { get; set; }
        public string DriverNin { get; set; }
        public string VehicleId { get; set; }
        public Guid? UserId { get; set; }
        public string UserName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string ServiceUrl { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public string ServiceRequest { get; set; }
        public string ServiceResponse { get; set; }
        public string ServerIp { get; set; }
        public Guid? RequestId { get; set; }
        public int? ServiceResponseTimeInSeconds { get; set; }
        public string Channel { get; set; }
        public string RetrievingMethod { get; set; }
        public bool? VehicleAgencyRepair { get; set; }
        public string City { get; set; }
    }
}
