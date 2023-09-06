﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class PromotionProgram
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public bool IsActive { get; set; }

    public string CreatedBy { get; set; }

    public string ModifiedBy { get; set; }

    public int ValidationMethodId { get; set; }

    public DateTime? DeactivatedDate { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string Key { get; set; }

    public bool? IsPromoByEmail { get; set; }

    public bool? IsPromoByNin { get; set; }

    public bool? IsPromoByAttachment { get; set; }

    public bool? EnableService { get; set; }

    public virtual AspNetUsers CreatedByNavigation { get; set; }

    public virtual AspNetUsers ModifiedByNavigation { get; set; }

    public virtual ICollection<PromotionProgramCode> PromotionProgramCode { get; set; } = new List<PromotionProgramCode>();

    public virtual ICollection<PromotionProgramDomain> PromotionProgramDomain { get; set; } = new List<PromotionProgramDomain>();

    public virtual ICollection<PromotionProgramUser> PromotionProgramUser { get; set; } = new List<PromotionProgramUser>();

    public virtual ICollection<UserPurchasedPromotionPrograms> UserPurchasedPromotionPrograms { get; set; } = new List<UserPurchasedPromotionPrograms>();
}