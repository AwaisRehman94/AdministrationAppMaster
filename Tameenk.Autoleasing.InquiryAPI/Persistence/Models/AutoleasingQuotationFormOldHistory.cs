﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class AutoleasingQuotationFormOldHistory
{
    public int Id { get; set; }

    public string? ExternalId { get; set; }

    public string? VehicleId { get; set; }

    public int? DeductableValue { get; set; }

    public bool? AgencyRepair { get; set; }

    public bool IsLocked { get; set; }

    public bool IsDone { get; set; }
}
