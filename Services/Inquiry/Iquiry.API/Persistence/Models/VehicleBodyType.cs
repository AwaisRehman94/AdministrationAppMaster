using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class VehicleBodyType
{
    public byte Code { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }

    public bool? IsActive { get; set; }

    public string? YakeenCode { get; set; }

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
