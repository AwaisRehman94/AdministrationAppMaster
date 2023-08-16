using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class VehicleModel
{
    public long Code { get; set; }

    public short VehicleMakerCode { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }

    public short? TawuniyaMakerCode { get; set; }

    public long? TawuniyaModelCode { get; set; }

    public short? WataniyaMakerCode { get; set; }

    public long? WataniyaModelCode { get; set; }

    public byte VehicleBodyCode { get; set; }

    public virtual VehicleMaker VehicleMakerCodeNavigation { get; set; } = null!;
}
