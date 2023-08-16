using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class UserClaimHistory
{
    public int Id { get; set; }

    public int ClaimId { get; set; }

    public int ClaimStatusId { get; set; }

    public string ClaimStatusName { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }
}
