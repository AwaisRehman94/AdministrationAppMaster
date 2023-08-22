using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

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
