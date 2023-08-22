using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class WareefDiscountBenefit
{
    public int Id { get; set; }

    public string? BenefitDescriptionAr { get; set; }

    public string? BenefitDescriptionEn { get; set; }

    public bool? IsDeleted { get; set; }

    public int? DescountId { get; set; }
}
