using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class InsuranceCompanyProductTypeConfig
{
    public short ProductTypeCode { get; set; }

    public int InsuranceCompanyId { get; set; }

    public byte MinDriverAge { get; set; }

    public byte MaxDriverAge { get; set; }

    public byte MaxVehicleAge { get; set; }

    public virtual ProductType ProductTypeCodeNavigation { get; set; } = null!;
}
