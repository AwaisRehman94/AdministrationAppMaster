﻿using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class TempPriceDetail
{
    public Guid DetailId { get; set; }

    public Guid ProductId { get; set; }

    public byte PriceTypeCode { get; set; }

    public decimal PriceValue { get; set; }

    public decimal? PercentageValue { get; set; }
}