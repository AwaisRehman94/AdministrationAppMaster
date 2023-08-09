using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class TabbyWebHookDetail
{
    public long Id { get; set; }

    public long TabbyWebHookId { get; set; }

    public string? Buyer { get; set; }

    public string? ShippingAddress { get; set; }

    public string? Order { get; set; }

    public string? BuyerHistory { get; set; }

    public string? OrderHistory { get; set; }

    public string? Refunds { get; set; }

    public string? Captures { get; set; }

    public string? Meta { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual TabbyWebHook TabbyWebHook { get; set; } = null!;
}
