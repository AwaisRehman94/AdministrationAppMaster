using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class Country
{
    public short Code { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }
}
