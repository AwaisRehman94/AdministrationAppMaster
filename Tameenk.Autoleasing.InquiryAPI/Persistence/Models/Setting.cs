﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class Setting
{
    public int Id { get; set; }

    public int? MaxNumberOfPolicies { get; set; }

    public int? MaxNumberOfPromotionCode { get; set; }
}
