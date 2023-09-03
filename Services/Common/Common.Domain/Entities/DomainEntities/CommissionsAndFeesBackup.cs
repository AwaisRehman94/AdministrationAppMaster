﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class CommissionsAndFeesBackup
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string CompanyKey { get; set; }

    public int? InsuranceTypeCode { get; set; }

    public string Key { get; set; }

    public decimal? Percentage { get; set; }

    public decimal? FixedFees { get; set; }

    public bool? CalculatedFromBasic { get; set; }

    public bool? IsCommission { get; set; }

    public int? PaymentMethodId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string ModifiedBy { get; set; }

    public bool? IncludeAdditionalDriver { get; set; }

    public bool? IsPercentageNegative { get; set; }

    public bool? IsFixedFeesNegative { get; set; }
}