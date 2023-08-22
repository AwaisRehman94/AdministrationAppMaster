using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class ErrorCode
{
    public short Code { get; set; }

    public string? EnglishText { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicText { get; set; }

    public string? ArabicDescription { get; set; }
}
