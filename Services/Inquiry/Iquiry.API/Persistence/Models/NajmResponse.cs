using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class NajmResponse
{
    public int Id { get; set; }

    public int? IsVehicleRegistered { get; set; }

    public string? PolicyHolderNin { get; set; }

    public string? VehicleId { get; set; }

    public string? Ncdreference { get; set; }

    public int? NcdfreeYears { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? IsDeleted { get; set; }
}
