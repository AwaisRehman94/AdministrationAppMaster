using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class VehicleUsage
{
    public int Id { get; set; }

    public int? PlateTypeCode { get; set; }

    public int? VehicleUseCode { get; set; }
}
