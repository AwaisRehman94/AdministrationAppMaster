using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class PromotionProgramDomain
{
    public int Id { get; set; }

    public int? PromotionProgramId { get; set; }

    public string Domian { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public string? DomainNameAr { get; set; }

    public string? DomainNameEn { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual AspNetUser? CreatedByNavigation { get; set; }

    public virtual AspNetUser? ModifiedByNavigation { get; set; }

    public virtual PromotionProgram? PromotionProgram { get; set; }
}
