﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class QuotationRequestAdditionalDriver
{
    public int QuotationRequestId { get; set; }

    public Guid AdditionalDriverId { get; set; }

    public byte? AdditionalDriverRelationShipId { get; set; }

    public virtual Driver AdditionalDriver { get; set; } = null!;

    public virtual QuotationRequest QuotationRequest { get; set; } = null!;
}
