using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class HyperpayResponse
{
    public int Id { get; set; }

    public int? HyperpayRequestId { get; set; }

    public string? HyperpayResponseId { get; set; }

    public string? ResponseCode { get; set; }

    public string? ReferenceId { get; set; }

    public decimal Amount { get; set; }

    public string? BuildNumber { get; set; }

    public string? Ndc { get; set; }

    public string? Timestamp { get; set; }

    public string? Descriptor { get; set; }

    public string? PaymentBrand { get; set; }

    public string? CardBin { get; set; }

    public string? Last4Digits { get; set; }

    public string? Holder { get; set; }

    public string? ExpiryMonth { get; set; }

    public string? ExpiryYear { get; set; }

    public string? Message { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsCancelled { get; set; }

    public DateTime? CancelationDate { get; set; }

    public string? CancelledBy { get; set; }

    public string? ServiceResponse { get; set; }
}
