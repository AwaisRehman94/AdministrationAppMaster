using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class MorniSm
{
    public int Id { get; set; }

    public string? PolicyNo { get; set; }

    public DateTime? PolicyStartDate { get; set; }

    public DateTime? PolicyEndDate { get; set; }

    public string? Vin { get; set; }

    public double VehicleRegistrationSerialNumber { get; set; }

    public string? OwnerFirstName { get; set; }

    public string? OwnerLastName { get; set; }

    public double OwnerMobilePhone { get; set; }

    public string? PlateInfo { get; set; }

    public string? Make { get; set; }

    public string? Model { get; set; }

    public double ModelYear { get; set; }

    public bool? IsSmssent { get; set; }

    public int? Lang { get; set; }
}
