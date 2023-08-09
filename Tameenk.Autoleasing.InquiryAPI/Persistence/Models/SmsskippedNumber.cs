using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class SmsskippedNumber
{
    public int Id { get; set; }

    public string? PhoneNo { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UserId { get; set; }

    public string? CreatedBy { get; set; }
}
