using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class OrderItemBenefit
{
    public int Id { get; set; }

    public int OrderItemId { get; set; }

    public short? BenefitId { get; set; }

    public decimal Price { get; set; }

    public string? BenefitExternalId { get; set; }

    public virtual Benefit? Benefit { get; set; }

    public virtual OrderItem OrderItem { get; set; } = null!;
}
