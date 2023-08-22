using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class Benefit
{
    public short Code { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }

    public virtual ICollection<InsuaranceCompanyBenefit> InsuaranceCompanyBenefits { get; set; } = new List<InsuaranceCompanyBenefit>();

    public virtual ICollection<InvoiceBenefit> InvoiceBenefits { get; set; } = new List<InvoiceBenefit>();

    public virtual ICollection<OrderItemBenefit> OrderItemBenefits { get; set; } = new List<OrderItemBenefit>();

    public virtual ICollection<ProductBenefit> ProductBenefits { get; set; } = new List<ProductBenefit>();
}
