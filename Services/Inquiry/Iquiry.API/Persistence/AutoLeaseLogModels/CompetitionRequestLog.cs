using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels;

public partial class CompetitionRequestLog
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserIp { get; set; }

    public string? UserAgent { get; set; }

    public string? ServerIp { get; set; }

    public string? Channel { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public string? Method { get; set; }

    public string? VehicleId { get; set; }

    public string? Nin { get; set; }

    public string? ServiceRequest { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? VehicleAgencyRepair { get; set; }

    public string? City { get; set; }
}
