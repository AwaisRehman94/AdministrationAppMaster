﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class QuotationBlockedNin
{
    public int Id { get; set; }

    public string? NationalId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? BlockReason { get; set; }
}
