using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class WareefDescount
{
    public int Id { get; set; }

    public string? DescountValue { get; set; }

    public bool? IsDeleted { get; set; }

    public int? WareefId { get; set; }

    public string? WdescountCode { get; set; }
}
