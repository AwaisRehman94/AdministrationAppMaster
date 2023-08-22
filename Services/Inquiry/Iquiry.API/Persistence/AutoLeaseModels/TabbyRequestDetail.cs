using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class TabbyRequestDetail
{
    public int Id { get; set; }

    public Guid? TabbyRequestId { get; set; }

    public string? Buyer { get; set; }

    public string? ShippingAddress { get; set; }

    public string? Order { get; set; }

    public string? BuyerHistory { get; set; }

    public string? OrderHistory { get; set; }

    public string? Meta { get; set; }

    public string? Attachment { get; set; }

    public string? Lang { get; set; }

    public string? MerchantCode { get; set; }

    public string? MerchantUrl { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual TabbyRequest? TabbyRequest { get; set; }
}
