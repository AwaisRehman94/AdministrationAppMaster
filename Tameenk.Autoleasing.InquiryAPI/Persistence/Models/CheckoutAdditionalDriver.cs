using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class CheckoutAdditionalDriver
{
    public string CheckoutDetailsId { get; set; } = null!;

    public Guid DriverId { get; set; }

    public int Id { get; set; }

    public virtual CheckoutDetail CheckoutDetails { get; set; } = null!;

    public virtual Driver Driver { get; set; } = null!;
}
