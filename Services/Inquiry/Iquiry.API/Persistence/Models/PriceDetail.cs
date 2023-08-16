using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class PriceDetail
{
    public Guid DetailId { get; set; }

    public Guid ProductId { get; set; }

    public byte PriceTypeCode { get; set; }

    public decimal PriceValue { get; set; }

    public decimal? PercentageValue { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public bool? IsCheckedOut { get; set; }

    public virtual PriceType PriceTypeCodeNavigation { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
