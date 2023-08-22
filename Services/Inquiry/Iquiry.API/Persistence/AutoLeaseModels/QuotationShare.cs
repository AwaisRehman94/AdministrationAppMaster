using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class QuotationShare
{
    public int Id { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? ExternalId { get; set; }

    public string? UserId { get; set; }

    public string? Channel { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public string? ShareType { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ServerIp { get; set; }

    public string? UserIp { get; set; }

    public string? UserAgent { get; set; }

    public string? Url { get; set; }
}
