using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class TabbyRequest
{
    public Guid Id { get; set; }

    public double? Amount { get; set; }

    public string? Currency { get; set; }

    public string? RefrenceId { get; set; }

    public string? UserId { get; set; }

    public string? Channel { get; set; }

    public DateTime? CreatedDate { get; set; }

    public double? InsuranceCompanyAmount { get; set; }

    public int? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public virtual ICollection<TabbyCaptureRequest> TabbyCaptureRequests { get; set; } = new List<TabbyCaptureRequest>();

    public virtual ICollection<TabbyNotification> TabbyNotifications { get; set; } = new List<TabbyNotification>();

    public virtual ICollection<TabbyRequestDetail> TabbyRequestDetails { get; set; } = new List<TabbyRequestDetail>();

    public virtual ICollection<TabbyResponse> TabbyResponses { get; set; } = new List<TabbyResponse>();

    public virtual ICollection<TabbyWebHook> TabbyWebHooks { get; set; } = new List<TabbyWebHook>();
}
