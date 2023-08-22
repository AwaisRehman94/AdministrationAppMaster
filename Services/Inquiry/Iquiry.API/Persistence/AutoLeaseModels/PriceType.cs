using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class PriceType
{
    public byte Code { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }

    public int? Order { get; set; }

    public virtual ICollection<PriceDetail> PriceDetails { get; set; } = new List<PriceDetail>();
}
