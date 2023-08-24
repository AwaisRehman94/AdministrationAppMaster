﻿using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels.Persistence.AutoLeaseLogModels
{
    public partial class NotificationLog
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int? InsuranceTypeCode { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public string Method { get; set; }
        public string Channel { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public double? ServiceResponseTimeInSeconds { get; set; }
        public bool? VehicleAgencyRepair { get; set; }
        public string City { get; set; }
    }
}
