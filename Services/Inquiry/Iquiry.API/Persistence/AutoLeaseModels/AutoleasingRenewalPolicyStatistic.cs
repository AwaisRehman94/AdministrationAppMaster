using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class AutoleasingRenewalPolicyStatistic
{
    public int Id { get; set; }

    public string? ReferenceId { get; set; }

    public string? SequenceNumber { get; set; }

    public string? ExternalId { get; set; }

    public string? ParentExternalId { get; set; }

    public int? Year { get; set; }

    public decimal? PaymentAmount { get; set; }

    public string? UserId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? ParentReferenceId { get; set; }

    public int? InsurancePercentage { get; set; }
}
