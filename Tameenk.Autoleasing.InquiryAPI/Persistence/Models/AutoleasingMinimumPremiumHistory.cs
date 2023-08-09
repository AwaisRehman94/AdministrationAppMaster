using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class AutoleasingMinimumPremiumHistory
{
    public int Id { get; set; }

    public int? BankId { get; set; }

    public string? ExternalId { get; set; }

    public decimal? FirstYear { get; set; }

    public decimal? SecondYear { get; set; }

    public decimal? ThirdYear { get; set; }

    public decimal? FourthYear { get; set; }

    public decimal? FifthYear { get; set; }

    public DateTime? CreatedDate { get; set; }
}
