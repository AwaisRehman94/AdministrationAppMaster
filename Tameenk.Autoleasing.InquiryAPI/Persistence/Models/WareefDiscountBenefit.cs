using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class WareefDiscountBenefit
{
    public int Id { get; set; }

    public string? BenefitDescriptionAr { get; set; }

    public string? BenefitDescriptionEn { get; set; }

    public bool? IsDeleted { get; set; }

    public int? DescountId { get; set; }
}
