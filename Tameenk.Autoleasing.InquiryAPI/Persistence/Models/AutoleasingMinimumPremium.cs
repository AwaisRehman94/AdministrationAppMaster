﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class AutoleasingMinimumPremium
{
    public int Id { get; set; }

    public int? BankId { get; set; }

    public decimal? FirstYear { get; set; }

    public decimal? SecondYear { get; set; }

    public decimal? ThirdYear { get; set; }

    public decimal? FourthYear { get; set; }

    public decimal? FifthYear { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }
}
