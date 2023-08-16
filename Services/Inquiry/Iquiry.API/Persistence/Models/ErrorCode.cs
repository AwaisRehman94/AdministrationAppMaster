using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class ErrorCode
{
    public short Code { get; set; }

    public string? EnglishText { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicText { get; set; }

    public string? ArabicDescription { get; set; }
}
