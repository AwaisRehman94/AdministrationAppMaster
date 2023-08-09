﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class IntegrationTransactionToBeDeleted
{
    public int Id { get; set; }

    public Guid? MessageId { get; set; }

    public string? Method { get; set; }

    public string? InputParams { get; set; }

    public string? OutputResults { get; set; }

    public int? Status { get; set; }

    public DateTime? TransactionDate { get; set; }
}
