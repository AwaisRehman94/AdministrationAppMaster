﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class HyperPayNotificationTransaction
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UniqueId { get; set; }

    public decimal? PayoutTransferAmount { get; set; }

    public string? MerchantTransactionId { get; set; }

    public int NotificationId { get; set; }
}
