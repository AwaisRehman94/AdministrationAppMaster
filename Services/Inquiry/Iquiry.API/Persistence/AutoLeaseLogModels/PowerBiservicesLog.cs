using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels;

public partial class PowerBiservicesLog
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public string? Method { get; set; }

    public decimal? ServiceResponseTimeInSeconds { get; set; }

    public int? TotalRecord { get; set; }

    public string? ServerIp { get; set; }

    public string? UserIp { get; set; }

    public string? CompanyKey { get; set; }

    public string? UserAgent { get; set; }

    public string? Channel { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool? VehicleAgencyRepair { get; set; }

    public string? City { get; set; }
}
