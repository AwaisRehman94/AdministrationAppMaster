using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels;

public partial class IvrservicesLog
{
    public int Id { get; set; }

    public string? ServiceRequest { get; set; }

    public int ModuleId { get; set; }

    public string? ModuleName { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public string? Method { get; set; }

    public DateTime CreatedDate { get; set; }

    public decimal? ServiceResponseTimeInSeconds { get; set; }

    public string? ServerIp { get; set; }

    public string? UserIp { get; set; }

    public string? UserAgent { get; set; }

    public string? RequesterUrl { get; set; }
}
