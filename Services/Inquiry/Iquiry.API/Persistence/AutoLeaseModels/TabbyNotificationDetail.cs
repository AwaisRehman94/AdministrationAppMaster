using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class TabbyNotificationDetail
{
    public long Id { get; set; }

    public long TabbyNotificationId { get; set; }

    public string? Product { get; set; }

    public string? Buyer { get; set; }

    public string? ShippingAddress { get; set; }

    public string? Order { get; set; }

    public string? BuyerHistory { get; set; }

    public string? OrderHistory { get; set; }

    public string? Refunds { get; set; }

    public string? Captures { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual TabbyNotification TabbyNotification { get; set; } = null!;
}
