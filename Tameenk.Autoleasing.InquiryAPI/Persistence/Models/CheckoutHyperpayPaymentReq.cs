using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class CheckoutHyperpayPaymentReq
{
    public int HyperpayPaymenRequestId { get; set; }

    public string CheckoutdetailsId { get; set; } = null!;
}
