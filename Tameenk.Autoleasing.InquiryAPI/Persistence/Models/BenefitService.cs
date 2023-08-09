using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class BenefitService
{
    public int Id { get; set; }

    public string? ServiceName { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }
}
