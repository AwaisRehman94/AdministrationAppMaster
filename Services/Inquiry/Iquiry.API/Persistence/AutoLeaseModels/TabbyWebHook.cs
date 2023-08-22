using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class TabbyWebHook
{
    public long Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? InvoiceNo { get; set; }

    public string? RefrenceId { get; set; }

    public string? Channel { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public string PaymentId { get; set; } = null!;

    public string? CreatedAt { get; set; }

    public string? ExpiresAt { get; set; }

    public string? ClosedAt { get; set; }

    public string? Status { get; set; }

    public bool? IsTest { get; set; }

    public double Amount { get; set; }

    public string? Currency { get; set; }

    public string? Description { get; set; }

    public bool? Cancelable { get; set; }

    public string? UserId { get; set; }

    public string? MerchantId { get; set; }

    public string? ProductOptionId { get; set; }

    public Guid TabbyRequestId { get; set; }

    public virtual TabbyRequest TabbyRequest { get; set; } = null!;

    public virtual ICollection<TabbyWebHookDetail> TabbyWebHookDetails { get; set; } = new List<TabbyWebHookDetail>();
}
