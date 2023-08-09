using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class ShoppingCartItemDriver
{
    public int Id { get; set; }

    public int ShoppingCartItemId { get; set; }

    public int ProductDriverId { get; set; }
}
