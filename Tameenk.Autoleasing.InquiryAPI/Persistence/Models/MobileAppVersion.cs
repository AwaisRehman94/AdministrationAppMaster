﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class MobileAppVersion
{
    public int Id { get; set; }

    public string Version { get; set; } = null!;

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public DateTime CreationDate { get; set; }

    public string? Platform { get; set; }

    public string? Url { get; set; }
}
