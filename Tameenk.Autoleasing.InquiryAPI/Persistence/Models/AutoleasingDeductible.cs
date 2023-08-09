using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class AutoleasingDeductible
{
    public int Id { get; set; }

    public decimal? Value { get; set; }

    public bool? IsActive { get; set; }
}
