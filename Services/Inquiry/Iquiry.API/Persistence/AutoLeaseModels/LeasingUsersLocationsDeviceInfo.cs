using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class LeasingUsersLocationsDeviceInfo
{
    public int Id { get; set; }

    public int LeasingUserId { get; set; }

    public string? UserId { get; set; }

    public string? UserIp { get; set; }

    public string? UserName { get; set; }

    public string? ServerIp { get; set; }

    public string? DeviceName { get; set; }

    public string? DeviceType { get; set; }

    public string? Client { get; set; }

    public string? Os { get; set; }

    public DateTime CreatedDate { get; set; }
}
