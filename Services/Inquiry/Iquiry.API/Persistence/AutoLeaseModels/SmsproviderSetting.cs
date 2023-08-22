using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class SmsproviderSetting
{
    public int Id { get; set; }

    public string? Method { get; set; }

    public string? Module { get; set; }

    public string? Smsprovider { get; set; }
}
