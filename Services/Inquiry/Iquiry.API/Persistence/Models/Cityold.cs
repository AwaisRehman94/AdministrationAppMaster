using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class Cityold
{
    public long Code { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }

    public int? RegionId { get; set; }
}
