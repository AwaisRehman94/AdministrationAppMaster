using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class PolicyStatus
{
    public int Id { get; set; }

    public string? Key { get; set; }

    public string NameEn { get; set; } = null!;

    public string NameAr { get; set; } = null!;

    public virtual ICollection<CheckoutDetail> CheckoutDetails { get; set; } = new List<CheckoutDetail>();
}
