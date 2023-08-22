using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class LicenseType
{
    public short Code { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }

    public int? WataniyaCode { get; set; }

    public int? AutoleasingWataniyaCode { get; set; }

    public virtual ICollection<DriverLicense> DriverLicenses { get; set; } = new List<DriverLicense>();
}
