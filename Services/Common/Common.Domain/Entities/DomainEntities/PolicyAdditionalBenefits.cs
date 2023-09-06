﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class PolicyAdditionalBenefits
{
    public int Id { get; set; }

    public string ReferenceId { get; set; }

    public string QuotationReferenceId { get; set; }

    public string PolicyNo { get; set; }

    public int? InsuranceCompanyId { get; set; }

    public int? InsuranceTypeCode { get; set; }

    public int? BenefitCode { get; set; }

    public string BenefitId { get; set; }

    public string BenefitNameAr { get; set; }

    public string BenefitNameEn { get; set; }

    public string BenefitDescAr { get; set; }

    public string BenefitDescEn { get; set; }

    public decimal? BenefitPrice { get; set; }

    public DateTime? BenefitEffectiveDate { get; set; }

    public DateTime? BenefitExpiryDate { get; set; }

    public decimal? DeductibleValue { get; set; }

    public decimal? TaxableAmount { get; set; }

    public decimal? Vatamount { get; set; }
}