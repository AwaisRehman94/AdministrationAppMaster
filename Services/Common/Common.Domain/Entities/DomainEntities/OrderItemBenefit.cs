﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class OrderItemBenefit
{
    public int Id { get; set; }

    public int OrderItemId { get; set; }

    public short? BenefitId { get; set; }

    public decimal Price { get; set; }

    public string BenefitExternalId { get; set; }

    public virtual Benefit Benefit { get; set; }

    public virtual OrderItem OrderItem { get; set; }
}