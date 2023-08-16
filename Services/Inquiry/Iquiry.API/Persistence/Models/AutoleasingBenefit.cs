using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class AutoleasingBenefit
{
    public int Id { get; set; }

    public short? Code { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }
}
