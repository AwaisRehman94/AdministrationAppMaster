﻿using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class HyperPayCreateOrder
{
    public int Id { get; set; }

    public string? ServiceRequest { get; set; }

    public string? RequestConfigId { get; set; }

    public string? MerchantTransactionId { get; set; }

    public string? UniqueId { get; set; }

    public string? Period { get; set; }

    public string? TransferOption { get; set; }

    public string? RequestPaymentBrand { get; set; }

    public string? ReferenceId { get; set; }

    public string? Channel { get; set; }

    public string? ServiceResponse { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? ResponseStatus { get; set; }

    public string? ResponseMessage { get; set; }
}