using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class Gender
{
    public string Code { get; set; } = null!;

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }
}
