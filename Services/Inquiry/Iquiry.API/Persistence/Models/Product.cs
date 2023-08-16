using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class Product
{
    public Guid Id { get; set; }

    public string? ExternalProductId { get; set; }

    public string QuotaionNo { get; set; } = null!;

    public DateTime? QuotationDate { get; set; }

    public DateTime? QuotationExpiryDate { get; set; }

    public int? ProviderId { get; set; }

    public string? ProductNameAr { get; set; }

    public string? ProductNameEn { get; set; }

    public string? ProductDescAr { get; set; }

    public string? ProductDescEn { get; set; }

    public decimal ProductPrice { get; set; }

    public int? DeductableValue { get; set; }

    public int? VehicleLimitValue { get; set; }

    public long? QuotationResponseId { get; set; }

    public string? ProductImage { get; set; }

    public int? InsuranceTypeCode { get; set; }

    public bool IsPromoted { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public bool? IsCheckedOut { get; set; }

    public string? ReferenceId { get; set; }

    public decimal? InsurancePercentage { get; set; }

    public decimal? ShadowAmount { get; set; }

    public string? DeductibleType { get; set; }

    public int? Odlimit { get; set; }

    public int? Tpllimit { get; set; }

    public decimal? PolicyPremium { get; set; }

    public decimal? AnnualPremiumBfd { get; set; }

    public virtual ICollection<CheckoutDetail> CheckoutDetails { get; set; } = new List<CheckoutDetail>();

    public virtual ICollection<PriceDetail> PriceDetails { get; set; } = new List<PriceDetail>();

    public virtual ICollection<ProductBenefit> ProductBenefits { get; set; } = new List<ProductBenefit>();

    public virtual InsuranceCompany? Provider { get; set; }

    public virtual QuotationResponse? QuotationResponse { get; set; }
}
