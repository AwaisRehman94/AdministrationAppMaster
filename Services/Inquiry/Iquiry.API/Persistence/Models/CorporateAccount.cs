using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class CorporateAccount
{
    public int Id { get; set; }

    public string? NameEn { get; set; }

    public string? NameAr { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public decimal? Balance { get; set; }

    public bool? IsActive { get; set; }
}
