using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class BankCode
{
    public int Id { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }

    public int? ValidationCode { get; set; }

    public string Code { get; set; } = null!;
}
