using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class Nationality
{
    public int Id { get; set; }

    public double? Code { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }
}
