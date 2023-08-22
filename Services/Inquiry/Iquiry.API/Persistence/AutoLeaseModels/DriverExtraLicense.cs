using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class DriverExtraLicense
{
    public int Id { get; set; }

    public Guid DriverId { get; set; }

    public short CountryCode { get; set; }

    public int? LicenseYearsId { get; set; }

    public virtual Driver Driver { get; set; } = null!;
}
