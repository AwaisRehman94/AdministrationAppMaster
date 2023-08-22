using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class PromotionProgram
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public int ValidationMethodId { get; set; }

    public DateTime? DeactivatedDate { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? Key { get; set; }

    public bool? IsPromoByEmail { get; set; }

    public bool? IsPromoByNin { get; set; }

    public bool? IsPromoByAttachment { get; set; }

    public bool? EnableService { get; set; }

    public virtual AspNetUser? CreatedByNavigation { get; set; }

    public virtual AspNetUser? ModifiedByNavigation { get; set; }

    public virtual ICollection<PromotionProgramCode> PromotionProgramCodes { get; set; } = new List<PromotionProgramCode>();

    public virtual ICollection<PromotionProgramDomain> PromotionProgramDomains { get; set; } = new List<PromotionProgramDomain>();

    public virtual ICollection<PromotionProgramUser> PromotionProgramUsers { get; set; } = new List<PromotionProgramUser>();

    public virtual ICollection<UserPurchasedPromotionProgram> UserPurchasedPromotionPrograms { get; set; } = new List<UserPurchasedPromotionProgram>();
}
