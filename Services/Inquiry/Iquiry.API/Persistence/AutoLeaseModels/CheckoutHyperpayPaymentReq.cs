using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class CheckoutHyperpayPaymentReq
{
    public int HyperpayPaymenRequestId { get; set; }

    public string CheckoutdetailsId { get; set; } = null!;
}
