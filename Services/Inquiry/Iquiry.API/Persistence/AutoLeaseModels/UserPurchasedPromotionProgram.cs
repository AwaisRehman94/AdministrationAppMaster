using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class UserPurchasedPromotionProgram
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public int PromotionProgramId { get; set; }

    public int? InsuranceCompanyId { get; set; }

    public virtual InsuranceCompany? InsuranceCompany { get; set; }

    public virtual PromotionProgram PromotionProgram { get; set; } = null!;

    public virtual AspNetUser User { get; set; } = null!;
}
