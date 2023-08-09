﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class HyperpayRequest
{
    public int Id { get; set; }

    public string? ReferenceId { get; set; }

    public decimal Amount { get; set; }

    public string? RequestId { get; set; }

    public string? UserId { get; set; }

    public string? PaymentType { get; set; }

    public string? Currency { get; set; }

    public string? ReturnUrl { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ResponseCode { get; set; }

    public string? ResponseDescription { get; set; }

    public string? ResponseBuildNumber { get; set; }

    public string? ResponseTimestamp { get; set; }

    public string? ResponseNdc { get; set; }

    public string? ResponseId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? StatusDescription { get; set; }

    public string? StatusJsonResponse { get; set; }

    public string? ServiceRequest { get; set; }

    public Guid? MerchantTransactionId { get; set; }

    public string? NationalId { get; set; }
}
