﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class QuotationResponse
{
    public long Id { get; set; }

    public int? RequestId { get; set; }

    public short? InsuranceTypeCode { get; set; }

    public bool? VehicleAgencyRepair { get; set; }

    public int? DeductibleValue { get; set; }

    public string ReferenceId { get; set; }

    public int InsuranceCompanyId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string IcquoteReferenceNo { get; set; }

    public string PromotionProgramCode { get; set; }

    public int? PromotionProgramId { get; set; }

    public long? CityId { get; set; }

    public bool? IsCheckedOut { get; set; }

    public bool AutoleasingInitialOption { get; set; }

    public virtual InsuranceCompany InsuranceCompany { get; set; }

    public virtual ProductType InsuranceTypeCodeNavigation { get; set; }

    public virtual ICollection<Product> Product { get; set; } = new List<Product>();

    public virtual QuotationRequest Request { get; set; }
}