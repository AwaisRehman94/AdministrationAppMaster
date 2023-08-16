using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class VehicleRequest
{
    public int Id { get; set; }

    public string? VehicleId { get; set; }

    public string? DriverNin { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? CityId { get; set; }
}
