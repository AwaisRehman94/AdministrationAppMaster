using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class PayfortPaymentResponse
{
    public int Id { get; set; }

    public int RequestId { get; set; }

    public int ResponseCode { get; set; }

    public string? ResponseMessage { get; set; }

    public decimal? Amount { get; set; }

    public string? PaymentOption { get; set; }

    public string? CardNumber { get; set; }

    public string? CardHolerName { get; set; }

    public string? CardExpiryDate { get; set; }

    public string? CustomerIp { get; set; }

    public string? FortId { get; set; }

    public short? Status { get; set; }

    public string? CustomerEmail { get; set; }

    public string? Signature { get; set; }

    public virtual PayfortPaymentRequest Request { get; set; } = null!;
}
