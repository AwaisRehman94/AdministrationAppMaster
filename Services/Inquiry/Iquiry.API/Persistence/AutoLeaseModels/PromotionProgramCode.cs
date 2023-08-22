using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class PromotionProgramCode
{
    public int Id { get; set; }

    public int? PromotionProgramId { get; set; }

    public string Code { get; set; } = null!;

    public int InsuranceCompanyId { get; set; }

    public bool IsDeleted { get; set; }

    public string? CreatorId { get; set; }

    public string? ModifierId { get; set; }

    public short InsuranceTypeCode { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public virtual AspNetUser? Creator { get; set; }

    public virtual InsuranceCompany InsuranceCompany { get; set; } = null!;

    public virtual ProductType InsuranceTypeCodeNavigation { get; set; } = null!;

    public virtual AspNetUser? Modifier { get; set; }

    public virtual PromotionProgram? PromotionProgram { get; set; }
}
