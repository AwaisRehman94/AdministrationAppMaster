using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class PayfortPaymentRequest
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public decimal? Amount { get; set; }

    public string ReferenceNumber { get; set; } = null!;

    public bool? IsCancelled { get; set; }

    public DateTime? CancelationDate { get; set; }

    public string? CancelledBy { get; set; }

    public virtual ICollection<PayfortPaymentResponse> PayfortPaymentResponses { get; set; } = new List<PayfortPaymentResponse>();

    public virtual ICollection<CheckoutDetail> Checkoutdetails { get; set; } = new List<CheckoutDetail>();

    public virtual ICollection<PolicyUpdateRequest> PolicyUpdateRequests { get; set; } = new List<PolicyUpdateRequest>();
}
