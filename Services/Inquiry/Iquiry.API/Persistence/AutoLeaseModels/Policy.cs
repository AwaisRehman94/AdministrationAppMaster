using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class Policy
{
    public int Id { get; set; }

    public int? InsuranceCompanyId { get; set; }

    public byte StatusCode { get; set; }

    public string PolicyNo { get; set; } = null!;

    public DateTime? PolicyIssueDate { get; set; }

    public DateTime? PolicyEffectiveDate { get; set; }

    public DateTime? PolicyExpiryDate { get; set; }

    public string CheckOutDetailsId { get; set; } = null!;

    public Guid? PolicyFileId { get; set; }

    public string? NajmStatus { get; set; }

    public bool IsRefunded { get; set; }

    public int NajmStatusId { get; set; }

    public bool? IsCancelled { get; set; }

    public DateTime? CancelationDate { get; set; }

    public string? CancelledBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public double? NajmResponseTimeInSeconds { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? NotificationNo { get; set; }

    public bool? IsRenewed { get; set; }

    public string? RenewalNotificationStatus { get; set; }

    public virtual CheckoutDetail CheckOutDetails { get; set; } = null!;

    public virtual InsuranceCompany? InsuranceCompany { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual NajmStatus NajmStatusNavigation { get; set; } = null!;

    public virtual PolicyDetail? PolicyDetail { get; set; }

    public virtual PolicyFile? PolicyFile { get; set; }

    public virtual ICollection<PolicyUpdateRequest> PolicyUpdateRequests { get; set; } = new List<PolicyUpdateRequest>();
}
