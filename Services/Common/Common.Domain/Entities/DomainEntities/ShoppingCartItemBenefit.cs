﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class ShoppingCartItemBenefit
{
    public int Id { get; set; }

    public int ShoppingCartItemId { get; set; }

    public long? ProductBenefitId { get; set; }

    public virtual Product_Benefit ProductBenefit { get; set; }
}