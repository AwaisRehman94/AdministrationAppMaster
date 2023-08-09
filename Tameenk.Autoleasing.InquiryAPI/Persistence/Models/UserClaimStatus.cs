using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class UserClaimStatus
{
    public int Id { get; set; }

    public int StatusCode { get; set; }

    public string? StatusNameAr { get; set; }

    public string? StatusNameEn { get; set; }

    public int? NextStatusId { get; set; }
}
