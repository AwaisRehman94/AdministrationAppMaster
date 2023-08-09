﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class VehicleMaker
{
    public short Code { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }

    public short? TawuniyaCode { get; set; }

    public short? WataniyaCode { get; set; }

    public virtual ICollection<VehicleModel> VehicleModels { get; set; } = new List<VehicleModel>();
}
