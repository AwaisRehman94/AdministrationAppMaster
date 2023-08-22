using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels;

public partial class EmailLog
{
    public int Id { get; set; }

    public string? ReferenceId { get; set; }

    public string? Email { get; set; }

    public string? Method { get; set; }

    public string? Module { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public string? Channel { get; set; }

    public string? UserIp { get; set; }

    public string? ServerIp { get; set; }

    public string? UserAgent { get; set; }

    public string? SenderEmail { get; set; }

    public double? ServiceResponseTimeInSeconds { get; set; }
}
