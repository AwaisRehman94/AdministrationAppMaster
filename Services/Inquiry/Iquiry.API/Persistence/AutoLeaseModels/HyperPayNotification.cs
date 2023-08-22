using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class HyperPayNotification
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool Status { get; set; }

    public string? Message { get; set; }

    public string? Errors { get; set; }

    public string? BeneficiaryName { get; set; }

    public string? BeneficiaryAccountId { get; set; }

    public string? BatchId { get; set; }

    public string? EncryptedResponse { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorDescirption { get; set; }

    public string? ReferenceId { get; set; }

    public string? DecryptedResponse { get; set; }

    public string? ServerIp { get; set; }

    public string? UserIp { get; set; }

    public string? UserAgent { get; set; }

    public string? NotificationRefernece { get; set; }

    public decimal? DebitAmount { get; set; }
}
