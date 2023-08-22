using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels;

public partial class ForbiddenRequestLog
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UserIp { get; set; }

    public string? UserAgent { get; set; }

    public string? Referer { get; set; }

    public string? ServerIp { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public string? Request { get; set; }

    public string? UserName { get; set; }

    public bool? VehicleAgencyRepair { get; set; }

    public string? City { get; set; }
}
