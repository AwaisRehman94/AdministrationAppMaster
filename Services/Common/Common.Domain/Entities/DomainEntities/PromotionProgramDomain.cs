﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class PromotionProgramDomain
{
    public int Id { get; set; }

    public int? PromotionProgramId { get; set; }

    public string Domian { get; set; }

    public string CreatedBy { get; set; }

    public string ModifiedBy { get; set; }

    public string DomainNameAr { get; set; }

    public string DomainNameEn { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual AspNetUsers CreatedByNavigation { get; set; }

    public virtual AspNetUsers ModifiedByNavigation { get; set; }

    public virtual PromotionProgram PromotionProgram { get; set; }
}