using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class ProductType
{
    public short Code { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }

    public virtual ICollection<CheckoutDetail> CheckoutDetails { get; set; } = new List<CheckoutDetail>();

    public virtual ICollection<InsuranceCompanyProductTypeConfig> InsuranceCompanyProductTypeConfigs { get; set; } = new List<InsuranceCompanyProductTypeConfig>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<PromotionProgramCode> PromotionProgramCodes { get; set; } = new List<PromotionProgramCode>();

    public virtual ICollection<QuotationResponseNew> QuotationResponseNews { get; set; } = new List<QuotationResponseNew>();

    public virtual ICollection<QuotationResponse> QuotationResponses { get; set; } = new List<QuotationResponse>();
}
