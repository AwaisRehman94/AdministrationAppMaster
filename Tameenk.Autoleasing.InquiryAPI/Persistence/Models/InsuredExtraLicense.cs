using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class InsuredExtraLicense
{
    public int Id { get; set; }

    public int InsuredId { get; set; }

    public string DriverNin { get; set; } = null!;

    public bool IsMainDriver { get; set; }

    public int LicenseNumberYears { get; set; }

    public short LicenseCountryCode { get; set; }

    public DateTime? CreatedDate { get; set; }
}
