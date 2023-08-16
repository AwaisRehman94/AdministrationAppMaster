using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class TabbyCaptureResponse
{
    public long Id { get; set; }

    public long TabbyCaptureRequestId { get; set; }

    public string? RefrenceId { get; set; }

    public string? UserId { get; set; }

    public string? Channel { get; set; }

    public string? CreatedAt { get; set; }

    public string? ExpiresAt { get; set; }

    public bool Test { get; set; }

    public bool IsExpired { get; set; }

    public string? Status { get; set; }

    public bool Cancelable { get; set; }

    public string? Currency { get; set; }

    public string? OrderRefrenceId { get; set; }

    public string? CaptureId { get; set; }

    public double? Amount { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public virtual TabbyCaptureRequest TabbyCaptureRequest { get; set; } = null!;

    public virtual ICollection<TabbyCaptureResponseDetail> TabbyCaptureResponseDetails { get; set; } = new List<TabbyCaptureResponseDetail>();
}
