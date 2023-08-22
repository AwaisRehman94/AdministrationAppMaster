using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels;

public partial class PromotionRequestLog
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public string? MethodName { get; set; }

    public string? ApiUrl { get; set; }

    public string? Channel { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public string? ServiceRequest { get; set; }

    public string? ServerIp { get; set; }

    public string? UserIp { get; set; }

    public string? UserAgent { get; set; }

    public string? RequesterUrl { get; set; }

    public bool? VehicleAgencyRepair { get; set; }

    public string? City { get; set; }
}
