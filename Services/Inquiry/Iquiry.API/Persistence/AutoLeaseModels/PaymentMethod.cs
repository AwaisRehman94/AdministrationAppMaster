using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class PaymentMethod
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string? Name { get; set; }

    public bool Active { get; set; }

    public int Order { get; set; }

    public string? Brands { get; set; }

    public bool? IosEnabled { get; set; }

    public bool? AndroidEnabled { get; set; }

    public string? ArabicDescription { get; set; }

    public string? EnglishDescription { get; set; }

    public string? LogoUrl { get; set; }

    public virtual ICollection<CheckoutDetail> CheckoutDetails { get; set; } = new List<CheckoutDetail>();
}
