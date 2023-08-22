using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class CheckoutAdditionalDriver
{
    public string CheckoutDetailsId { get; set; } = null!;

    public Guid DriverId { get; set; }

    public int Id { get; set; }

    public virtual CheckoutDetail CheckoutDetails { get; set; } = null!;

    public virtual Driver Driver { get; set; } = null!;
}
