using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels;

public partial class Smslog
{
    public int Id { get; set; }

    public string? MobileNumber { get; set; }

    public string? Smsmessage { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Method { get; set; }

    public string? ServiceUrl { get; set; }

    public string? ServiceRequest { get; set; }

    public string? ServiceResponse { get; set; }

    public string? UserIp { get; set; }

    public string? ServerIp { get; set; }

    public string? UserAgent { get; set; }

    public string? Smsprovider { get; set; }

    public double? ServiceResponseTimeInSeconds { get; set; }

    public string? ReferenceId { get; set; }

    public string? Module { get; set; }

    public string? Channel { get; set; }

    public bool? VehicleAgencyRepair { get; set; }

    public string? City { get; set; }
}
