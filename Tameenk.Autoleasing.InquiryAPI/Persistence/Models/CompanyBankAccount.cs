﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class CompanyBankAccount
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string? ComapnyKey { get; set; }

    public string? BeneficiaryName { get; set; }

    public string? Bank { get; set; }

    public string? Iban { get; set; }

    public string? Swiftcode { get; set; }

    public decimal? TransferedPercentage { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? CrNumber { get; set; }
}
