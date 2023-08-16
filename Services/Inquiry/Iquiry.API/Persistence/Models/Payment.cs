using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class Payment
{
    public int BillNumber { get; set; }

    public string? ReferenceId { get; set; }

    public string? UserId { get; set; }

    public string? Ibna { get; set; }

    public int? BankCode { get; set; }

    public int? PaymentStatus { get; set; }
}
