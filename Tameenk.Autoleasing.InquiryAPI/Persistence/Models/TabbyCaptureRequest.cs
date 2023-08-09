using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class TabbyCaptureRequest
{
    public long Id { get; set; }

    public Guid? TabbyRequestId { get; set; }

    public string? RefrenceId { get; set; }

    public string? UserId { get; set; }

    public string? Channel { get; set; }

    public string? CreatedAt { get; set; }

    public string? Items { get; set; }

    public double? Amount { get; set; }

    public double? TaxAmount { get; set; }

    public double? DiscountAmount { get; set; }

    public double? ShippingAmount { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public virtual ICollection<TabbyCaptureResponse> TabbyCaptureResponses { get; set; } = new List<TabbyCaptureResponse>();

    public virtual TabbyRequest? TabbyRequest { get; set; }
}
