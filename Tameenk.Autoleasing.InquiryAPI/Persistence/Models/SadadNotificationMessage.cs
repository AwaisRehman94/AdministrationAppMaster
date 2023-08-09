using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class SadadNotificationMessage
{
    public int Id { get; set; }

    public string? HeadersReceiver { get; set; }

    public string? HeadersSender { get; set; }

    public string? HeadersMessageType { get; set; }

    public DateTime? HeadersTimeStamp { get; set; }

    public string? BodysAccountNo { get; set; }

    public decimal? BodysAmount { get; set; }

    public string? BodysCustomerRefNo { get; set; }

    public string? BodysTransType { get; set; }

    public string? BodysDescription { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsCancelled { get; set; }

    public DateTime? CancelationDate { get; set; }

    public string? CancelledBy { get; set; }

    public string? SadadRequestJson { get; set; }

    public virtual ICollection<SadadNotificationResponse> SadadNotificationResponses { get; set; } = new List<SadadNotificationResponse>();
}
