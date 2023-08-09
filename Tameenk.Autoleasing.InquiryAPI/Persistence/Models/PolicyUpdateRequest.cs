using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class PolicyUpdateRequest
{
    public int Id { get; set; }

    public int? PolicyId { get; set; }

    public int RequestTypeId { get; set; }

    public int StatusId { get; set; }

    public string? Guid { get; set; }

    public virtual Policy? Policy { get; set; }

    public virtual ICollection<PolicyUpdatePayment> PolicyUpdatePayments { get; set; } = new List<PolicyUpdatePayment>();

    public virtual ICollection<PolicyUpdateRequestAttachment> PolicyUpdateRequestAttachments { get; set; } = new List<PolicyUpdateRequestAttachment>();

    public virtual ICollection<PayfortPaymentRequest> PayfortPaymentRequests { get; set; } = new List<PayfortPaymentRequest>();
}
