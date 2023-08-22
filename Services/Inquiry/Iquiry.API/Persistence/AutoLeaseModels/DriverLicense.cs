using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class DriverLicense
{
    public int LicenseId { get; set; }

    public Guid DriverId { get; set; }

    public short? TypeDesc { get; set; }

    public string? ExpiryDateH { get; set; }

    public string? IssueDateH { get; set; }

    public string? LicnsTypeDesc { get; set; }

    public virtual Driver Driver { get; set; } = null!;

    public virtual LicenseType? TypeDescNavigation { get; set; }
}
