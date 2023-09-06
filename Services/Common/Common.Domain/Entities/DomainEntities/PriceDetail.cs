﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class PriceDetail
{
    public Guid DetailId { get; set; }

    public Guid ProductId { get; set; }

    public byte PriceTypeCode { get; set; }

    public decimal PriceValue { get; set; }

    public decimal? PercentageValue { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public bool? IsCheckedOut { get; set; }

    public virtual PriceType PriceTypeCodeNavigation { get; set; }

    public virtual Product Product { get; set; }
}