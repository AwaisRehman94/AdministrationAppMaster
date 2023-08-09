using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class PolicyUpdatePayment
{
    public int Id { get; set; }

    public int PolicyUpdateRequestId { get; set; }

    public decimal? Amount { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual PolicyUpdateRequest PolicyUpdateRequest { get; set; } = null!;
}
