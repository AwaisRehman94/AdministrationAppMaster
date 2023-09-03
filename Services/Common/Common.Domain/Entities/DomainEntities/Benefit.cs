﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class Benefit
{
    public short Code { get; set; }

    public string EnglishDescription { get; set; }

    public string ArabicDescription { get; set; }

    public virtual ICollection<InsuaranceCompanyBenefit> InsuaranceCompanyBenefit { get; set; } = new List<InsuaranceCompanyBenefit>();

    public virtual ICollection<InvoiceBenefit> InvoiceBenefit { get; set; } = new List<InvoiceBenefit>();

    public virtual ICollection<OrderItemBenefit> OrderItemBenefit { get; set; } = new List<OrderItemBenefit>();

    public virtual ICollection<ProductBenefit> ProductBenefit { get; set; } = new List<ProductBenefit>();
}