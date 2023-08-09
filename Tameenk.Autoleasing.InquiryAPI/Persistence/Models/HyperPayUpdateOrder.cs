﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class HyperPayUpdateOrder
{
    public int Id { get; set; }

    public bool? IsBcareUpdateOrder { get; set; }

    public string? ServiceRequest { get; set; }

    public string? RequestAmount { get; set; }

    public string? RequestConfigId { get; set; }

    public string? RequestUniqueId { get; set; }

    public string? RequestBeneficiaryAccountId { get; set; }

    public string? RequestPaymentBrand { get; set; }

    public string? ReferenceId { get; set; }

    public string? Channel { get; set; }

    public string? ResponseStatus { get; set; }

    public string? ResponseMessage { get; set; }

    public string? ResponseAmount { get; set; }

    public string? PayoutStatus { get; set; }

    public string? PayoutBeneficiaryName { get; set; }

    public string? PaymentType { get; set; }

    public string? ServiceResponse { get; set; }

    public DateTime? CreatedDate { get; set; }
}
