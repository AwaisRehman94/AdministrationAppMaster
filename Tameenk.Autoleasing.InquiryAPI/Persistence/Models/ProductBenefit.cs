using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class ProductBenefit
{
    public long Id { get; set; }

    public Guid? ProductId { get; set; }

    public short? BenefitId { get; set; }

    public bool? IsSelected { get; set; }

    public decimal? BenefitPrice { get; set; }

    public string? BenefitExternalId { get; set; }

    public bool? IsReadOnly { get; set; }

    public string? BenefitNameAr { get; set; }

    public string? BenefitNameEn { get; set; }

    public string? CoveredCountry { get; set; }

    public decimal? AveragePremium { get; set; }

    public int? Limit { get; set; }

    public virtual Benefit? Benefit { get; set; }

    public virtual Product? Product { get; set; }

    public virtual ICollection<ShoppingCartItemBenefit> ShoppingCartItemBenefits { get; set; } = new List<ShoppingCartItemBenefit>();
}
