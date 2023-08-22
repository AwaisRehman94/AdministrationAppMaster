using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class SadadNotificationResponse
{
    public int Id { get; set; }

    public int NotificationMessageId { get; set; }

    public string? HeadersReceiver { get; set; }

    public string? HeadersSender { get; set; }

    public string? HeadersMessageType { get; set; }

    public DateTime? HeadersTimeStamp { get; set; }

    public string Status { get; set; } = null!;

    public virtual SadadNotificationMessage NotificationMessage { get; set; } = null!;
}
