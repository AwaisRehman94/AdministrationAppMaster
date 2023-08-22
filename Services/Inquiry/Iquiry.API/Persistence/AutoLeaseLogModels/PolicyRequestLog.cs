﻿using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels;

public partial class PolicyRequestLog
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public Guid? UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserIp { get; set; }

    public string? UserAgent { get; set; }

    public Guid? RequestId { get; set; }

    public string? ServerIp { get; set; }

    public string? CompanyName { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public string? QuotationNo { get; set; }

    public int? ProductId { get; set; }

    public string? InsuredId { get; set; }

    public string? InsuredMobileNumber { get; set; }

    public string? InsuredEmail { get; set; }

    public string? InsuredCity { get; set; }

    public string? InsuredAddress { get; set; }

    public string? PaymentMethod { get; set; }

    public decimal? PaymentAmount { get; set; }

    public string? PaymentBillNumber { get; set; }

    public string? InsuredBankCode { get; set; }

    public string? InsuredBankName { get; set; }

    public string? InsuredIban { get; set; }

    public bool? VehicleAgencyRepair { get; set; }

    public string? City { get; set; }
}
