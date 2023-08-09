using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class ShoppingCartItemBenefit
{
    public int Id { get; set; }

    public int ShoppingCartItemId { get; set; }

    public long? ProductBenefitId { get; set; }

    public virtual ProductBenefit? ProductBenefit { get; set; }
}
