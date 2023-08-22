using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class AdditionalInfo
{
    public string ReferenceId { get; set; } = null!;

    public string? InfoAsJsonString { get; set; }

    public string? DriverAdditionalInfo { get; set; }

    public virtual CheckoutDetail Reference { get; set; } = null!;
}
