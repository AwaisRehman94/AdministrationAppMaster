using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class RenewalDiscount
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public int? DiscountType { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Percentage { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public int? UserId { get; set; }

    public bool IsActive { get; set; }

    public int? MessageType { get; set; }

    public int CodeType { get; set; }
}
