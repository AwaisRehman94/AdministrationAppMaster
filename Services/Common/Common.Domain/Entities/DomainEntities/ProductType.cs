﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class ProductType
{
    public short Code { get; set; }

    public string EnglishDescription { get; set; }

    public string ArabicDescription { get; set; }

    public virtual ICollection<CheckoutDetails> CheckoutDetails { get; set; } = new List<CheckoutDetails>();

    public virtual ICollection<InsuranceCompanyProductTypeConfig> InsuranceCompanyProductTypeConfig { get; set; } = new List<InsuranceCompanyProductTypeConfig>();

    public virtual ICollection<Invoice> Invoice { get; set; } = new List<Invoice>();

    public virtual ICollection<PromotionProgramCode> PromotionProgramCode { get; set; } = new List<PromotionProgramCode>();

    public virtual ICollection<QuotationResponse> QuotationResponse { get; set; } = new List<QuotationResponse>();

    public virtual ICollection<QuotationResponseNew> QuotationResponseNew { get; set; } = new List<QuotationResponseNew>();
}