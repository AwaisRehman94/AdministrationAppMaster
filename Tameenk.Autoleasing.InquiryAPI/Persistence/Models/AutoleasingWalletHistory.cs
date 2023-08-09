﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class AutoleasingWalletHistory
{
    public int Id { get; set; }

    public int? BankId { get; set; }

    public int? CompanyId { get; set; }

    public string? ReferenceId { get; set; }

    public decimal? Amount { get; set; }

    public string? Method { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? CompanyKey { get; set; }

    public decimal RemainingBalance { get; set; }
}
