﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class PromotionProgramCode
{
    public int Id { get; set; }

    public int? PromotionProgramId { get; set; }

    public string Code { get; set; }

    public int InsuranceCompanyId { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatorId { get; set; }

    public string ModifierId { get; set; }

    public short InsuranceTypeCode { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public virtual AspNetUsers Creator { get; set; }

    public virtual InsuranceCompany InsuranceCompany { get; set; }

    public virtual ProductType InsuranceTypeCodeNavigation { get; set; }

    public virtual AspNetUsers Modifier { get; set; }

    public virtual PromotionProgram PromotionProgram { get; set; }
}