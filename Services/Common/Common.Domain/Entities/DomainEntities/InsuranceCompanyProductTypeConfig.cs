﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class InsuranceCompanyProductTypeConfig
{
    public short ProductTypeCode { get; set; }

    public int InsuranceCompanyId { get; set; }

    public byte MinDriverAge { get; set; }

    public byte MaxDriverAge { get; set; }

    public byte MaxVehicleAge { get; set; }

    public virtual ProductType ProductTypeCodeNavigation { get; set; }
}